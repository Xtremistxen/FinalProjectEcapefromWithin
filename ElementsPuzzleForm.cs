using System.Windows.Forms;
using EscapefromWithin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EscapefromWithin
{
    // Puzzle where the player must choose the correct counter element
    public partial class ElementsPuzzleForm : Form
{
    // Shared game state so we can mark seal complete
    private readonly GameState state;

    // List of possible challenge elements
    private readonly string[] challengeElements =
    {
            "Fire", "Water", "Earth", "Wind", "Light", "Dark"
        };

    // Array of element buttons easy enable/disable
    private Button[] elementButtons;

    // Dictionary that stores what element counters what
    // Example: counter of Fire = Water means Water beats Fire
    private Dictionary<string, string> counterOf;

    // Random number generator for picking the challenge each round
    private readonly Random rng = new Random();

    // Current round number
    private int round = 0;

    // How many rounds player must win to solve puzzle
    private const int totalRounds = 12;

    // The element the player must counter this round
    private string currentChallenge = "";

    // True when puzzle is solved
    public bool PuzzleSolved { get; private set; } = false;

    // Log file path
    private readonly string logFilePath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzlelog.txt");

    // Constructor receives the shared GameState
    public ElementsPuzzleForm(GameState gameState)
    {
        InitializeComponent(); // Load UI controls

        // Store state and prevent null
        state = gameState ?? throw new ArgumentNullException(nameof(gameState));

        // Put all element buttons into an array for easy looping
        elementButtons = new Button[]
        {
                fireButton, waterButton, earthButton, windButton, lightButton, darkButton
        };

        // "What beats what" rules
        counterOf = new Dictionary<string, string>
            {
                { "Fire",  "Water" }, // Water beats Fire
                { "Water", "Earth" }, // Earth beats Water
                { "Earth", "Wind"  }, // Wind beats Earth
                { "Wind",  "Fire"  }, // Fire beats Wind

                { "Light", "Dark"  }, // Dark beats Light
                { "Dark",  "Light" }  // Light beats Dark
            };

        // Hook up each button click to call PlayerChose()
        fireButton.Click += (s, e) => PlayerChose("Fire");
        waterButton.Click += (s, e) => PlayerChose("Water");
        earthButton.Click += (s, e) => PlayerChose("Earth");
        windButton.Click += (s, e) => PlayerChose("Wind");
        lightButton.Click += (s, e) => PlayerChose("Light");
        darkButton.Click += (s, e) => PlayerChose("Dark");

        // Set labels/rules and start the first round
        SetupUI();
        StartNewRound();
    }

    // Sets up labels and checks if puzzle was already solved
    private void SetupUI()
    {
        // If already solved from save data, lock the puzzle
        if (state.SealElements)
        {
            PuzzleSolved = true;
            statusLabel.Text = "Seal already unlocked!";
            hintLabel.Text = "The element circle is already calm.";
            challengeLabel.Text = "Complete";
            SetButtonsEnabled(false);
            return;
        }

        // Show puzzle rules to the player
        hintLabel.Text =
            "Rules:\n" +
            "Pick the element that COUNTERS the challenge.\n\n" +
            "Examples:\n" +
            "Water beats Fire\n" +
            "Earth beats Water\n" +
            "Wind beats Earth\n" +
            "Fire beats Wind\n" +
            "Light and Dark counter each other";

        statusLabel.Text = "";
    }

    // Returns the counter element for the current challenge
    private string GetCounter(string challenge)
    {
        return counterOf[challenge];
    }

    // Checks if the player's choice is correct
    private bool IsCorrectChoice(string challenge, string chosen)
    {
        return GetCounter(challenge) == chosen;
    }

    // Starts a new round picks a new challenge
    private void StartNewRound()
    {
        // Do nothing if puzzle already solved
        if (PuzzleSolved) return;

        // If player completed all rounds, unlock the seal
        if (round >= totalRounds)
        {
            UnlockSeal();
            return;
        }

        // Pick a random challenge element
        currentChallenge = challengeElements[rng.Next(0, challengeElements.Length)];

        // Safety check: if dictionary is missing a key default to Fire
        try
        {
            string counter = GetCounter(currentChallenge);
        }
        catch
        {
            currentChallenge = "Fire";
        }

        // Update labels for the player
        challengeLabel.Text = $"Challenge: {currentChallenge}";
        statusLabel.Text = $"Round {round + 1}/{totalRounds}: choose the counter!";
    }

    // Runs when the player clicks an element button
    private void PlayerChose(string chosen)
    {
        try
        {
            // Ignore clicks if already solved
            if (PuzzleSolved) return;

            // If correct go to next round
            if (IsCorrectChoice(currentChallenge, chosen))
            {
                statusLabel.Text = $" Correct! {chosen} counters {currentChallenge}.";
                round++;
                StartNewRound();
            }
            else
            {
                // Wrong choice resets puzzle
                statusLabel.Text = $" Wrong! {chosen} does NOT counter {currentChallenge}. Resetting…";
                ResetPuzzle();
            }
        }
        catch (Exception ex)
        {
            // Any error: show message and reset
            statusLabel.Text = "Error: " + ex.Message;
            ResetPuzzle();
        }
    }

    // Marks puzzle solved and updates game state
    private void UnlockSeal()
    {
        PuzzleSolved = true;
        state.SealElements = true;

        // Update UI to show success
        challengeLabel.Text = "Seal Unlocked!";
        statusLabel.Text = " You mastered the elemental counters!";
        SetButtonsEnabled(false);
        returnButton.Text = "Return to Foyer (Seal Unlocked)";

        // Optional: write to log file
        try
        {
            File.AppendAllText(logFilePath, $"{DateTime.Now} - Elements counter puzzle solved.\n");
        }
        catch { }
    }

    // Resets puzzle progress back to round 0
    private void ResetPuzzle()
    {
        if (PuzzleSolved) return;

        round = 0;
        StartNewRound();
    }

    // Enables/disables all element buttons
    private void SetButtonsEnabled(bool enabled)
    {
        foreach (Button b in elementButtons)
            b.Enabled = enabled;
    }

    // Reset button click (manual reset)
    private void resetButton_Click(object sender, EventArgs e)
    {
        ResetPuzzle();
        statusLabel.Text = "Reset. Try again!";
    }

    // Return button closes this form
    private void returnButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    // Save button saves current game state
    private void saveButton_Click(object sender, EventArgs e)
    {
        SaveService.Save(state);
        MessageBox.Show("Saved!");
    }
}
}