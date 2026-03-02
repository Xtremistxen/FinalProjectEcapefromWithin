namespace EscapefromWithin
{
    partial class ElementsPuzzleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementsPuzzleForm));
            fireButton = new Button();
            waterButton = new Button();
            earthButton = new Button();
            lightButton = new Button();
            darkButton = new Button();
            challengeLabel = new Label();
            statusLabel = new Label();
            hintLabel = new Label();
            resetButton = new Button();
            returnButton = new Button();
            saveButton = new Button();
            windButton = new Button();
            SuspendLayout();
            // 
            // fireButton
            // 
            fireButton.BackColor = Color.Red;
            fireButton.Location = new Point(265, 265);
            fireButton.Name = "fireButton";
            fireButton.Size = new Size(75, 23);
            fireButton.TabIndex = 0;
            fireButton.Text = "Fire";
            fireButton.UseVisualStyleBackColor = false;
            // 
            // waterButton
            // 
            waterButton.BackColor = Color.Aquamarine;
            waterButton.Location = new Point(265, 294);
            waterButton.Name = "waterButton";
            waterButton.Size = new Size(75, 23);
            waterButton.TabIndex = 1;
            waterButton.Text = "Water";
            waterButton.UseVisualStyleBackColor = false;
            // 
            // earthButton
            // 
            earthButton.BackColor = Color.Sienna;
            earthButton.Location = new Point(355, 267);
            earthButton.Name = "earthButton";
            earthButton.Size = new Size(75, 23);
            earthButton.TabIndex = 2;
            earthButton.Text = "Earth";
            earthButton.UseVisualStyleBackColor = false;
            // 
            // lightButton
            // 
            lightButton.BackColor = Color.LightGoldenrodYellow;
            lightButton.Location = new Point(448, 267);
            lightButton.Name = "lightButton";
            lightButton.Size = new Size(75, 23);
            lightButton.TabIndex = 3;
            lightButton.Text = "Light";
            lightButton.UseVisualStyleBackColor = false;
            // 
            // darkButton
            // 
            darkButton.BackColor = Color.DarkSlateBlue;
            darkButton.Location = new Point(448, 296);
            darkButton.Name = "darkButton";
            darkButton.Size = new Size(75, 23);
            darkButton.TabIndex = 4;
            darkButton.Text = "Dark";
            darkButton.UseVisualStyleBackColor = false;
            // 
            // challengeLabel
            // 
            challengeLabel.AutoSize = true;
            challengeLabel.BackColor = Color.Transparent;
            challengeLabel.ForeColor = Color.Gold;
            challengeLabel.Location = new Point(355, 155);
            challengeLabel.Name = "challengeLabel";
            challengeLabel.Size = new Size(0, 15);
            challengeLabel.TabIndex = 5;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.ForeColor = Color.Gold;
            statusLabel.Location = new Point(371, 9);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 15);
            statusLabel.TabIndex = 6;
            // 
            // hintLabel
            // 
            hintLabel.AutoSize = true;
            hintLabel.BackColor = Color.Transparent;
            hintLabel.ForeColor = Color.Gold;
            hintLabel.Location = new Point(12, 9);
            hintLabel.Name = "hintLabel";
            hintLabel.Size = new Size(0, 15);
            hintLabel.TabIndex = 7;
            // 
            // resetButton
            // 
            resetButton.ForeColor = Color.DarkRed;
            resetButton.Location = new Point(355, 358);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 8;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // returnButton
            // 
            returnButton.ForeColor = Color.DarkRed;
            returnButton.Location = new Point(713, 380);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(75, 23);
            returnButton.TabIndex = 9;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // saveButton
            // 
            saveButton.ForeColor = Color.DarkRed;
            saveButton.Location = new Point(713, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // windButton
            // 
            windButton.BackColor = Color.DeepSkyBlue;
            windButton.Location = new Point(355, 296);
            windButton.Name = "windButton";
            windButton.Size = new Size(75, 23);
            windButton.TabIndex = 11;
            windButton.Text = "Wind";
            windButton.UseVisualStyleBackColor = false;
            // 
            // ElementsPuzzleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(windButton);
            Controls.Add(saveButton);
            Controls.Add(returnButton);
            Controls.Add(resetButton);
            Controls.Add(hintLabel);
            Controls.Add(statusLabel);
            Controls.Add(challengeLabel);
            Controls.Add(darkButton);
            Controls.Add(lightButton);
            Controls.Add(earthButton);
            Controls.Add(waterButton);
            Controls.Add(fireButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ElementsPuzzleForm";
            Text = "ElementsPuzzleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fireButton;
        private Button waterButton;
        private Button earthButton;
        private Button lightButton;
        private Button darkButton;
        private Label challengeLabel;
        private Label statusLabel;
        private Label hintLabel;
        private Button resetButton;
        private Button returnButton;
        private Button saveButton;
        private Button windButton;
    }
}