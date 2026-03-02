using System;
using System.Windows.Forms;

namespace EscapefromWithin
{
    
    public partial class FrontDoorForm : Form
    {
        private readonly GameState gameState;
        // Tracks if the player has picked up the key
        private bool hasKey = false;
        private GameState state;

        public FrontDoorForm(GameState gameState)
        {
            InitializeComponent();
            state = gameState ?? throw new ArgumentNullException(nameof(gameState)); // Got a null error; added this exemption to prevent

            // Initial UI state
            keyPictureBox.Visible = false;  // key starts hidden
            unlockDoorButton.Enabled = false;  // can't unlock until key is collected

            if (infoLabel != null)
                infoLabel.Text = "Something feels off... maybe check around the door.";
        }

        // Hovering over the potted plant reveals the hidden key
        private void plantPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (!hasKey)
            {
                keyPictureBox.Visible = true;

                if (infoLabel != null)
                    infoLabel.Text = "You notice something under the planter...";
            }
        }

        // Clicking the key picks it up
        private void keyPictureBox_Click(object sender, EventArgs e)
        {
            if (!hasKey)
            {
                hasKey = true;
                keyPictureBox.Visible = false; // hide key after pickup
                unlockDoorButton.Enabled = true; // now you can unlock the door

                if (infoLabel != null)
                    infoLabel.Text = "You found a rusted key. It might fit the lock.";
            }
        }

        // Unlock door -> go to FoyerForm
        private void unlockDoorButton_Click(object sender, EventArgs e)
        {
            if (!hasKey)
            {
                MessageBox.Show("The door is locked. You need a key.", "Locked");
                return;
            }

            state.CurrentLocation = "Foyer";
            // Open the foyer and close this form
            FoyerForm foyer = new FoyerForm(state);
            foyer.Show();
            this.Hide(); // or this.Close(); 
        }
    }
}


