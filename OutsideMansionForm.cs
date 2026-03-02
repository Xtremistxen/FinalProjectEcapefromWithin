using System;
using System.Windows.Forms;

namespace EscapefromWithin
{
    // First scene of the game outside the mansion
    public partial class OutsideMansionForm : Form
    {
        // Shared game state keeps track of location and progress
        private readonly GameState state;

        // Constructor receives the current GameState
        public OutsideMansionForm(GameState gameState)
        {
            InitializeComponent(); // Load UI controls

            // Store state and prevent null errors
            state = gameState ?? throw new ArgumentNullException(nameof(gameState));

            // Update player location for save/load system
            state.CurrentLocation = "Outside";

            // Display story text
            infoLabel.Text =
                "You stand before a mansion. You are unsure how you got here, " +
                "you went to sleep and woke up here so you thought maybe this could be a dream?... " +
                "The Mansion lights are on, maybe someone can help?...";
        }

        // Runs when the door button is clicked
        private void doorButton_Click(object sender, EventArgs e)
        {
            // Open the Front Door form
            FrontDoorForm door = new FrontDoorForm(state);
            door.Show();

            // Hide this form
            this.Hide();
        }

        // Runs when Save button is clicked
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save current game state
            SaveService.Save(state);

            // Let player know it saved
            infoLabel.Text = "Game saved.";
        }
    }
}

