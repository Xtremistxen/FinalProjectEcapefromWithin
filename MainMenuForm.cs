using System;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace EscapefromWithin
{
    // Main menu for the game
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent(); // Loads the UI elements

        }


        private void startButton_Click(object sender, EventArgs e) // Runs when the startButton_Click is clicked
        {
            GameState state = new GameState(); // Creats a new game state
            state.CurrentLocation = "Outside"; // Sets the starting location

            OutsideMansionForm outside = new OutsideMansionForm(state); // opens the OutsideMansionForm
            outside.Show();
            this.Hide();  // Hides the menu
        }

        private void loadButton_Click(object sender, EventArgs e) // Runs when the load button is clicked
        {
            GameState state = SaveService.LoadOrNew(); // Load a saved game or creat a new one
            OpenByLocation(state);
        }

        // Decision logic (if/else) for loading to correct place, chooses whic hform to open based on location
        private void OpenByLocation(GameState state)
        {
            if (state.CurrentLocation == "Outside") // Checks if player is outside
            {
                OutsideMansionForm outside = new OutsideMansionForm(state);
                outside.Show();
                this.Hide();
            }
            else if (state.CurrentLocation == "FrontDoor") // Checks if player is in front of door
            {
                FrontDoorForm door = new FrontDoorForm(state);
                door.Show();
                this.Hide();
            }
            else // otherwise sends player to Foyer or anything else
            {
                FoyerForm foyer = new FoyerForm(state);
                foyer.Show();
                this.Hide();
            }
        }

    }
}

