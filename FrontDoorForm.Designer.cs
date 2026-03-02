namespace EscapefromWithin
{
    partial class FrontDoorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontDoorForm));
            unlockDoorButton = new Button();
            unlockButton = new Button();
            infoLabel = new Label();
            keyLabel = new Label();
            backButton = new Button();
            saveButton = new Button();
            plantPictureBox = new PictureBox();
            keyPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)plantPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)keyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // unlockDoorButton
            // 
            unlockDoorButton.BackColor = Color.WhiteSmoke;
            unlockDoorButton.ForeColor = Color.DarkRed;
            unlockDoorButton.Location = new Point(325, 160);
            unlockDoorButton.Name = "unlockDoorButton";
            unlockDoorButton.Size = new Size(75, 23);
            unlockDoorButton.TabIndex = 0;
            unlockDoorButton.Text = "unlock";
            unlockDoorButton.UseVisualStyleBackColor = false;
            unlockDoorButton.Click += unlockDoorButton_Click;
            // 
            // unlockButton
            // 
            unlockButton.Enabled = false;
            unlockButton.Location = new Point(147, 185);
            unlockButton.Name = "unlockButton";
            unlockButton.Size = new Size(83, 23);
            unlockButton.TabIndex = 3;
            unlockButton.Text = "Unlock Door";
            unlockButton.UseVisualStyleBackColor = true;
            unlockButton.Click += unlockDoorButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.BackColor = Color.Transparent;
            infoLabel.ForeColor = Color.DarkRed;
            infoLabel.Location = new Point(12, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(169, 174);
            infoLabel.TabIndex = 1;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(607, 168);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(0, 15);
            keyLabel.TabIndex = 2;
            keyLabel.Visible = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.WhiteSmoke;
            backButton.ForeColor = Color.DarkRed;
            backButton.Location = new Point(12, 424);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 3;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.WhiteSmoke;
            saveButton.ForeColor = Color.DarkRed;
            saveButton.Location = new Point(713, 424);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // plantPictureBox
            // 
            plantPictureBox.BackColor = Color.Transparent;
            plantPictureBox.Cursor = Cursors.Hand;
            plantPictureBox.Location = new Point(633, 278);
            plantPictureBox.Name = "plantPictureBox";
            plantPictureBox.Size = new Size(40, 30);
            plantPictureBox.TabIndex = 5;
            plantPictureBox.TabStop = false;
            plantPictureBox.Click += keyPictureBox_Click;
            // 
            // keyPictureBox
            // 
            keyPictureBox.BackColor = Color.Transparent;
            keyPictureBox.Location = new Point(619, 212);
            keyPictureBox.Name = "keyPictureBox";
            keyPictureBox.Size = new Size(70, 96);
            keyPictureBox.TabIndex = 6;
            keyPictureBox.TabStop = false;
            keyPictureBox.Visible = false;
            keyPictureBox.MouseEnter += plantPictureBox_MouseEnter;
            // 
            // FrontDoorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(unlockDoorButton);
            Controls.Add(plantPictureBox);
            Controls.Add(keyPictureBox);
            Controls.Add(saveButton);
            Controls.Add(backButton);
            Controls.Add(keyLabel);
            Controls.Add(infoLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrontDoorForm";
            Text = "FrontDoorForm";
            ((System.ComponentModel.ISupportInitialize)plantPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)keyPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label infoLabel;
        private Label keyLabel;
        private Button unlockButton;
        private Button backButton;
        private Button saveButton;
        private PictureBox plantPictureBox;
        private PictureBox keyPictureBox;
        private Button unlockDoorButton;
    }
}