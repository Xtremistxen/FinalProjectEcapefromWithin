using System;
using System.IO;
using System.Windows.Forms;

namespace EscapefromWithin
{
    // Puzzle where the player must click portraits in the correct order
    public partial class PaintingPuzzleForm : Form
    {
        // Shared game state used to unlock the seal
        private readonly GameState state;

        // Correct order of portrait button indexes
        private readonly int[] correctOrder = new int[] { 3, 1, 6, 0, 7, 2, 5, 4 };

        // Array holding all portrait buttons makes looping easier
        private Button[] portraitButtons;

        // Tracks which step the player is currently on
        private int currentStep = 0;

        // True when puzzle is completed
        public bool PuzzleSolved { get; private set; } = false;

        // Log file path this was optional I wanted to test the savetxt again
        private readonly string logFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzlelog.txt");

        // Constructor receives shared GameState
        public PaintingPuzzleForm(GameState gameState)
        {
            InitializeComponent(); // Load UI controls

            // Store state prevent null errors
            state = gameState ?? throw new ArgumentNullException(nameof(gameState));

            // Put all portrait buttons into an array
            portraitButtons = new Button[]
            {
                portraitButton1, portraitButton2, portraitButton3, portraitButton4,
                portraitButton5, portraitButton6, portraitButton7, portraitButton8
            };

            // Hook up each portrait button to one click handler
            for (int i = 0; i < portraitButtons.Length; i++)
            {
                int index = i; // Local copy so lambda remembers correct index
                portraitButtons[i].Click += (s, e) => OnPortraitClicked(index);
            }

            SetupUI();
        }

        // Sets up labels and checks if puzzle was already solved
        private void SetupUI()
        {
            // If already solved from save file
            if (state.SealPainting)
            {
                PuzzleSolved = true;
                statusLabel.Text = "Seal already unlocked!";
                hintLabel.Text = "The portraits stare silently…";
                DisablePortraits();
                return;
            }

            // Reset puzzle state
            currentStep = 0;
            statusLabel.Text = "Step 1/8";

            // Display riddle hint
            hintLabel.Text =
                "Riddle Hint:\n" +
                "“The Baron watches first.\n" +
                "The child follows.\n" +
                "The hunter waits.\n" +
                "Then the servant.\n" +
                "The widow listens.\n" +
                "The scholar speaks.\n" +
                "The knight stands.\n" +
                "And last… the jester smiles.”";

            // Reset button appearance
            ResetPortraitStyles();
        }

        // Checks if clicked portrait matches correct order
        private bool IsCorrectChoice(int step, int clickedIndex)
        {
            return correctOrder[step] == clickedIndex;
        }

        // Builds step progress text
        private string StepText(int step, int total)
        {
            return $"Step {step}/{total}";
        }

        // Runs when any portrait is clicked
        private void OnPortraitClicked(int clickedIndex)
        {
            try
            {
                // Ignore clicks if already solved
                if (PuzzleSolved)
                    return;

                // Safety check for step range
                if (currentStep < 0 || currentStep >= correctOrder.Length)
                    throw new InvalidOperationException("Puzzle step is out of range. Resetting puzzle.");

                // If correct portrait was clicked
                if (IsCorrectChoice(currentStep, clickedIndex))
                {
                    // Disable that portrait and mark it complete
                    portraitButtons[clickedIndex].Enabled = false;
                    portraitButtons[clickedIndex].Text = $"✔ {portraitButtons[clickedIndex].Text}";

                    currentStep++;

                    // If all steps complete, unlock seal
                    if (currentStep >= correctOrder.Length)
                    {
                        UnlockSeal();
                        return;
                    }

                    // Update step label
                    statusLabel.Text = StepText(currentStep + 1, correctOrder.Length);
                }
                else
                {
                    // Wrong choice resets puzzle
                    statusLabel.Text = "Wrong portrait… the eyes shift. Resetting!";
                    ResetPuzzle();
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors safely
                statusLabel.Text = "Error: " + ex.Message;
                ResetPuzzle();
            }
        }

        // Marks puzzle complete and updates game state
        private void UnlockSeal()
        {
            PuzzleSolved = true;
            state.SealPainting = true;

            statusLabel.Text = "Painting Seal Unlocked!";
            hintLabel.Text = "A hidden latch clicks behind the canvas…";

            // Disable all portraits
            DisablePortraits();

            // Optional: write to log file
            try
            {
                File.AppendAllText(logFilePath,
                    $"{DateTime.Now} - Painting puzzle solved.\n");
            }
            catch
            {
                // Ignore logging errors
            }

            returnButton.Text = "Return to Foyer (Seal Unlocked)";
        }

        // Resets puzzle back to step 1
        private void ResetPuzzle()
        {
            currentStep = 0;
            statusLabel.Text = "Step 1/8";
            ResetPortraitStyles();
        }

        // Resets all portrait buttons to default state
        private void ResetPortraitStyles()
        {
            for (int i = 0; i < portraitButtons.Length; i++)
            {
                portraitButtons[i].Enabled = true;
                portraitButtons[i].Text = $"Portrait {i + 1}";
            }
        }

        // Disables all portrait buttons
        private void DisablePortraits()
        {
            for (int i = 0; i < portraitButtons.Length; i++)
            {
                portraitButtons[i].Enabled = false;
            }
        }

        // Manual reset button click
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (PuzzleSolved)
            {
                statusLabel.Text = "Already solved — no need to reset.";
                return;
            }

            ResetPuzzle();
            statusLabel.Text = "Reset. Try again!";
        }

        // Return button closes this puzzle form
        private void returnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Save button saves the game state
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveService.Save(state);
            MessageBox.Show("Saved!");
        }
    }
}