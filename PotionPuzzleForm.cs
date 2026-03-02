using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscapefromWithin
{
    // Potion puzzle where player must choose the correct brewing steps in order
    public partial class PotionPuzzleForm : Form
    {
        // Shared game state so we can unlock the seal
        private readonly GameState state;

        // The correct steps in the exact order the player must follow
        private readonly string[] correctSteps =
        {
            "Crushed Ashwinder Egg",
            "Stir Clockwise (3)",
            "Add Murtlap Tentacle",
            "Stir Counterclockwise (1)",
            "Add Squill Bulb Juice",
            "Simmer (10 seconds)"
        };

        // Incorrect choices that can appear as decoys
        private readonly string[] wrongChoices =
        {
            "Stir Clockwise (7)",
            "Add Powdered Moonstone",
            "Add Beetle Eyes",
            "Boil (30 seconds)",
            "Stir Counterclockwise (4)"
        };

        // Tracks which step the player is currently on
        private int currentStepIndex = 0;

        // Stores what the player has chosen so far for progress display
        private List<string> playerSteps = new List<string>();

        // True when puzzle is completed
        public bool PuzzleSolved { get; private set; } = false;

        // Constructor receives shared GameState
        public PotionPuzzleForm(GameState gameState)
        {
            InitializeComponent(); // Load UI controls

            // Store state and prevent null errors
            state = gameState ?? throw new ArgumentNullException(nameof(gameState));

            // Setup labels and check if already solved
            SetupUI();

            // Load the first step options
            LoadStep();
        }

        // Sets up the UI and handles "already solved" state
        private void SetupUI()
        {
            // Clear any old messages/progress
            resultLabel.Text = "";
            progressListBox.Items.Clear();

            // If already solved from save data, lock the puzzle
            if (state.SealPotion)
            {
                PuzzleSolved = true;
                resultLabel.Text = "Seal already unlocked!";
                addButton.Enabled = false;
            }
        }

        // Loads choices into the combo box for the current step
        private void LoadStep()
        {
            // Clear old options
            choiceComboBox.Items.Clear();

            // Always include the correct choice for this step
            choiceComboBox.Items.Add(correctSteps[currentStepIndex]);

            // Add a few random wrong choices (decoys)
            Random rng = new Random();
            HashSet<int> used = new HashSet<int>();

            // Keep adding wrong choices until we have 3 (or run out)
            while (used.Count < 3 && used.Count < wrongChoices.Length)
            {
                int pick = rng.Next(0, wrongChoices.Length);
                if (used.Add(pick))
                    choiceComboBox.Items.Add(wrongChoices[pick]);
            }

            // Nothing selected by default
            choiceComboBox.SelectedIndex = -1;

            // Show hint for this step and instructions
            hintLabel.Text = GetHintForStep(currentStepIndex);
            instructionLabel.Text = "Pick the correct step, then click Add.\nWrong choice resets the brew.";
        }

        // Returns a hint message based on the current step number
        private string GetHintForStep(int stepIndex)
        {
            if (stepIndex == 0) return "Textbook: start with a base ingredient. Notes: ash first.";
            else if (stepIndex == 1) return "Notes: don’t over-stir. Just 3 turns.";
            else if (stepIndex == 2) return "Textbook: add tentacle after heat stabilizes. Notes agree.";
            else if (stepIndex == 3) return "Notes: reverse once to prevent clumping.";
            else if (stepIndex == 4) return "Textbook: bulb juice near the end. Notes: exact timing matters.";
            else return "Notes: simmer—don’t boil—or it’s ruined.";
        }

        // Checks if a selected choice is the correct step
        private bool IsCorrectChoice(int stepIndex, string choice)
        {
            return correctSteps[stepIndex] == choice;
        }

        // Runs when Add button is clicked
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Must pick an option first
                if (choiceComboBox.SelectedIndex == -1)
                    throw new InvalidOperationException("Pick an option first!");

                // Get selected text from combo box
                string choice = choiceComboBox.SelectedItem?.ToString() ?? "";

                // If correct choice, save it and move forward
                if (IsCorrectChoice(currentStepIndex, choice))
                {
                    // Record step for progress display
                    playerSteps.Add(choice);
                    progressListBox.Items.Add(choice);

                    resultLabel.Text = "Correct.";

                    // Go to next step
                    currentStepIndex++;

                    // If all steps completed, puzzle is solved
                    if (currentStepIndex >= correctSteps.Length)
                    {
                        PuzzleSolved = true;

                        // Mark seal solved in GameState
                        state.SealPotion = true;

                        resultLabel.Text = "Potion complete! Seal of Fortune unlocked!";

                        // Disable add button so player can’t keep clicking
                        addButton.Enabled = false;

                        // Update return button text
                        returnButton.Text = "Return to Foyer (Seal Unlocked)";
                        return;
                    }

                    // Load options for the next step
                    LoadStep();
                }
                else
                {
                    // Give a slightly different message depending on what was wrong
                    if (choice.Contains("Stir") || choice.Contains("Boil") || choice.Contains("Simmer"))
                        resultLabel.Text = "Wrong technique/timing — the mixture destabilizes. Resetting!";
                    else
                        resultLabel.Text = "Wrong ingredient — the potion curdles instantly. Resetting!";

                    // Reset everything back to step 1
                    ResetPuzzle();
                }
            }
            catch (InvalidOperationException ex)
            {
                // Player didn’t select anything, etc.
                resultLabel.Text = ex.Message;
            }
            catch (Exception ex)
            {
                // Any unexpected error
                resultLabel.Text = "Unexpected error: " + ex.Message;
            }
        }

        // Runs when Reset button is clicked
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetPuzzle();
            resultLabel.Text = "Reset. Try again!";
        }

        // Resets the puzzle to the beginning
        private void ResetPuzzle()
        {
            currentStepIndex = 0;
            playerSteps.Clear();
            progressListBox.Items.Clear();
            LoadStep();
        }

        // Return button closes this form go back to previous screen
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save button saves the game state
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveService.Save(state);
            MessageBox.Show("Saved!");
        }
    }
}