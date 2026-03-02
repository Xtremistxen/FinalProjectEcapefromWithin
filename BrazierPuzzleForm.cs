using System;
using System.IO;
using System.Windows.Forms;

namespace EscapefromWithin
{
    // Puzzle form where the player must click braziers in the correct order
    public partial class BrazierPuzzleForm : Form
    {
        // Shared game state so we can mark the seal as solved
        private readonly GameState state;

        // The correct button order
        private readonly int[] correctOrder = new int[] { 2, 5, 3, 1, 0, 7, 6, 4 };

        // Array of all brazier buttons makes looping easy
        private Button[] braziers;

        // Tracks which step the player is currently on
        private int currentStep = 0;

        // True when puzzle is solved prevents extra clicks
        public bool PuzzleSolved { get; private set; } = false;

        // Where we write a small log message when solved
        private readonly string logFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzlelog.txt");

        // Constructor receives current game state
        public BrazierPuzzleForm(GameState gameState)
        {
            InitializeComponent(); // Load UI controls

            // Store game state and prevent null state
            state = gameState ?? throw new ArgumentNullException(nameof(gameState));

            // Put all brazier buttons into an array
            braziers = new Button[]
            {
                brazierButton1, brazierButton2, brazierButton3, brazierButton4,
                brazierButton5, brazierButton6, brazierButton7, brazierButton8
            };

            // Hook up one click event for each button using a loop
            for (int i = 0; i < braziers.Length; i++)
            {
                int index = i; // local copy so the lambda remembers the correct button
                braziers[i].Click += (s, e) => OnBrazierClicked(index);
            }

            // Set initial text / hint / enabled states
            SetupUI();
        }

        // Sets the labels and starting state of the puzzle
        private void SetupUI()
        {
            // If already solved in save data lock everything and show message
            if (state.SealBrazier)
            {
                PuzzleSolved = true;
                statusLabel.Text = "Seal already unlocked!";
                hintLabel.Text = "The braziers glow faintly… already complete.";
                SetBraziersEnabled(false);
                return;
            }

            // Start fresh
            PuzzleSolved = false;
            currentStep = 0;

            statusLabel.Text = "Light the braziers in the correct order.";

            // Riddle/hint shown to the player
            hintLabel.Text =
            "Eight flames whisper in silence...\n" +
            "The third flame wakes the circle.\n" +
            "Then the sixth answers the call.\n" +
            "Followed by the fourth, then second.\n" +
            "The first remembers.\n" +
            "The eighth listens.\n" +
            "The seventh waits.\n" +
            "And finally... the fifth burns bright.";

            // Reset all buttons back to normal
            ResetBraziers();
        }

        // Checks if the clicked brazier matches the correct one for this step
        private bool IsCorrectBrazier(int stepIndex, int clickedIndex)
        {
            return correctOrder[stepIndex] == clickedIndex;
        }

        // Builds the step text shown to the player
        private string MakeStepText(int step, int total)
        {
            return $"Step {step}/{total}";
        }

        // Runs when any brazier is clicked
        private void OnBrazierClicked(int clickedIndex)
        {
            try
            {
                // Ignore clicks once solved
                if (PuzzleSolved)
                    return;

                // Safety check in case currentStep somehow breaks
                if (currentStep < 0 || currentStep >= correctOrder.Length)
                    throw new InvalidOperationException("Puzzle step out of range. Resetting.");

                // If the player clicked the correct brazier for this step
                if (IsCorrectBrazier(currentStep, clickedIndex))
                {
                    // Disable that button and mark it as lit
                    braziers[clickedIndex].Enabled = false;
                    braziers[clickedIndex].Text = $"🔥 {clickedIndex + 1}";

                    // Move to next step
                    currentStep++;

                    // Update status label shows next step number
                    statusLabel.Text = MakeStepText(currentStep + 1, correctOrder.Length);

                    // If all steps completed, unlock the seal
                    if (currentStep >= correctOrder.Length)
                    {
                        UnlockSeal();
                        return;
                    }
                }
                else
                {
                    // Wrong click resets the whole puzzle
                    statusLabel.Text = "Wrong brazier… the flames die out. Resetting!";
                    ResetPuzzle();
                }
            }
            catch (Exception ex)
            {
                // If anything goes wrong show error and reset
                statusLabel.Text = "Error: " + ex.Message;
                ResetPuzzle();
            }
        }

        // Marks puzzle solved and updates the game state
        private void UnlockSeal()
        {
            PuzzleSolved = true;

            // Save progress into the shared GameState
            state.SealBrazier = true;

            statusLabel.Text = "Brazier Seal Unlocked!";
            hintLabel.Text = "A hidden mechanism clicks somewhere in the mansion…";

            // Disable all braziers now that it's complete
            SetBraziersEnabled(false);

            // Update return button text
            returnButton.Text = "Return to Foyer (Seal Unlocked)";

            // Try to write a simple log entry
            try
            {
                File.AppendAllText(logFilePath, $"{DateTime.Now} - Brazier puzzle solved.\n");
            }
            catch
            {
                // Ignore log errors game should still work
            }
        }

        // Resets puzzle progress back to step 0
        private void ResetPuzzle()
        {
            currentStep = 0;
            statusLabel.Text = "Light the braziers in the correct order.";
            ResetBraziers();
        }

        // Resets all brazier buttons to enabled and numbered
        private void ResetBraziers()
        {
            for (int i = 0; i < braziers.Length; i++)
            {
                braziers[i].Enabled = true;
                braziers[i].Text = (i + 1).ToString(); // show button number
            }
        }

        // Enables or disables all braziers at once
        private void SetBraziersEnabled(bool enabled)
        {
            for (int i = 0; i < braziers.Length; i++)
                braziers[i].Enabled = enabled;
        }

        // Reset button click
        private void resetButton_Click(object sender, EventArgs e)
        {
            // If already solved, don't allow resetting
            if (PuzzleSolved)
            {
                statusLabel.Text = "Already solved — no reset needed.";
                return;
            }

            ResetPuzzle();
        }

        // Return button closes this form goes back to previous screen
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
