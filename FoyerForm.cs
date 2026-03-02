using System;
using System.Windows.Forms;

namespace EscapefromWithin
{

    // Foyer form screen that tracks the player puzzle progress
    public partial class FoyerForm : Form
    {
        private readonly GameState state;

        public FoyerForm(GameState gameState) // Stores the shared GameState
        {
            InitializeComponent(); // The Constructor recieves the current GameState
            state = gameState ?? throw new ArgumentNullException(nameof(gameState));

            infoLabel.Text = "You have entered the Mansion, you hear a voice in your head...'Prove that you can Escape using your greatest strength your mind Solve 4 puzzles and unlock their seals to be free'";

            state.CurrentLocation = "Foyer"; // Updates the players current location for save/load
            UpdateSealUI();
        }

        // Updates the seal text and escape button status!
        private void UpdateSealUI()
        {
            // Array + loop requirement also counts solved seals and puts them into an array
            bool[] seals =
            {
                state.SealBrazier,
                state.SealPotion,
                state.SealPainting,
                state.SealElements
            };
            // Counts how many seals are solved
            int solved = 0;
            for (int i = 0; i < seals.Length; i++)
            {
                if (seals[i]) solved++;
            }

            sealsCountLabel.Text = $"Seals Unlocked: {solved}/4"; // Displays the number of unlocked Seals

            // Checks what state each is in and updates them accordingly
            brazierSealLabel.Text = state.SealBrazier ? "Brazier Seal: OPEN" : "Brazier Seal: LOCKED";
            potionSealLabel.Text = state.SealPotion ? "Potion Seal: OPEN" : "Potion Seal: LOCKED";
            paintingSealLabel.Text = state.SealPainting ? "Painting Seal: OPEN" : "Painting Seal: LOCKED";
            elementsSealLabel.Text = state.SealElements ? "Elements Seal: OPEN" : "Elements Seal: LOCKED";

            escapeButton.Enabled = (solved == 4); // Enables the escape button once all puzzles are solved and collected all seals
        }

        // Hook each puzzle button click
        private void brazierButton_Click(object sender, EventArgs e)
        {
            using (BrazierPuzzleForm puzzle = new BrazierPuzzleForm(state))
            {
                puzzle.ShowDialog();
            }

            UpdateSealUI();
            brazierButton.Enabled = !state.SealBrazier;
        }
        // Each button bewlow will run when according to each puzzleButton_Click then sent to that puzzles form to solve the puzzle and escape button aswell
        private void potionButton_Click(object sender, EventArgs e)
        {
            using (PotionPuzzleForm puzzle = new PotionPuzzleForm(state))
            {
                puzzle.ShowDialog();
            }

            UpdateSealUI(); // refresh buttons + escape logic
            potionButton.Enabled = !state.SealPotion;
        }

        private void paintingButton_Click(object sender, EventArgs e)
        {
            using (PaintingPuzzleForm puzzle = new PaintingPuzzleForm(state))
            {
                puzzle.ShowDialog();
            }

            UpdateSealUI(); // refresh buttons + escape logic
            paintingButton.Enabled = !state.SealPotion;
        }

        private void elementsButton_Click(object sender, EventArgs e)
        {
            using (ElementsPuzzleForm puzzle = new ElementsPuzzleForm(state))
            {
                puzzle.ShowDialog();
            }

            UpdateSealUI();
            elementsButton.Enabled = !state.SealElements;
        }

        private void escapeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All seals are broken… you escaped from within!", "EscapefromWithin");
            SaveService.Save(state);
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e) // Saves the current progress
        {
            SaveService.Save(state);
            MessageBox.Show("Saved!");
        }

    }
}
