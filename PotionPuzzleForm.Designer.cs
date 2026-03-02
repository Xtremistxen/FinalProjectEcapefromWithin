namespace EscapefromWithin
{
    partial class PotionPuzzleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotionPuzzleForm));
            instructionLabel = new Label();
            hintLabel = new Label();
            choiceComboBox = new ComboBox();
            addButton = new Button();
            resetButton = new Button();
            returnButton = new Button();
            saveButton = new Button();
            progressListBox = new ListBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.BackColor = Color.Transparent;
            instructionLabel.ForeColor = Color.Gold;
            instructionLabel.Location = new Point(12, 9);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(0, 15);
            instructionLabel.TabIndex = 0;
            // 
            // hintLabel
            // 
            hintLabel.AutoSize = true;
            hintLabel.BackColor = Color.Transparent;
            hintLabel.ForeColor = Color.Gold;
            hintLabel.Location = new Point(505, 292);
            hintLabel.Name = "hintLabel";
            hintLabel.Size = new Size(0, 15);
            hintLabel.TabIndex = 1;
            // 
            // choiceComboBox
            // 
            choiceComboBox.BackColor = Color.WhiteSmoke;
            choiceComboBox.ForeColor = Color.Gold;
            choiceComboBox.FormattingEnabled = true;
            choiceComboBox.Location = new Point(148, 334);
            choiceComboBox.Name = "choiceComboBox";
            choiceComboBox.Size = new Size(171, 23);
            choiceComboBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = Color.WhiteSmoke;
            addButton.ForeColor = Color.DarkRed;
            addButton.Location = new Point(353, 292);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add Ingredient";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.WhiteSmoke;
            resetButton.ForeColor = Color.DarkRed;
            resetButton.Location = new Point(366, 321);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 4;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.WhiteSmoke;
            returnButton.ForeColor = Color.DarkRed;
            returnButton.Location = new Point(713, 382);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(75, 23);
            returnButton.TabIndex = 5;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.WhiteSmoke;
            saveButton.ForeColor = Color.DarkRed;
            saveButton.Location = new Point(713, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // progressListBox
            // 
            progressListBox.BackColor = Color.WhiteSmoke;
            progressListBox.ForeColor = Color.Gold;
            progressListBox.FormattingEnabled = true;
            progressListBox.ItemHeight = 15;
            progressListBox.Location = new Point(125, 170);
            progressListBox.Name = "progressListBox";
            progressListBox.Size = new Size(160, 94);
            progressListBox.TabIndex = 7;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = Color.Transparent;
            resultLabel.ForeColor = Color.Gold;
            resultLabel.Location = new Point(125, 267);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(41, 15);
            resultLabel.TabIndex = 8;
            resultLabel.Text = "results";
            // 
            // PotionPuzzleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(progressListBox);
            Controls.Add(saveButton);
            Controls.Add(returnButton);
            Controls.Add(resetButton);
            Controls.Add(addButton);
            Controls.Add(choiceComboBox);
            Controls.Add(hintLabel);
            Controls.Add(instructionLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PotionPuzzleForm";
            Text = "PotionPuzzleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private Label hintLabel;
        private ComboBox choiceComboBox;
        private Button addButton;
        private Button resetButton;
        private Button returnButton;
        private Button saveButton;
        private ListBox progressListBox;
        private Label resultLabel;
    }
}