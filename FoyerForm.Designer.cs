namespace EscapefromWithin
{
    partial class FoyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoyerForm));
            sealsCountLabel = new Label();
            brazierSealLabel = new Label();
            potionSealLabel = new Label();
            paintingSealLabel = new Label();
            elementsSealLabel = new Label();
            brazierButton = new Button();
            potionButton = new Button();
            paintingButton = new Button();
            elementsButton = new Button();
            escapeButton = new Button();
            saveButton = new Button();
            infoLabel = new Label();
            SuspendLayout();
            // 
            // sealsCountLabel
            // 
            sealsCountLabel.AutoSize = true;
            sealsCountLabel.ForeColor = Color.DarkGoldenrod;
            sealsCountLabel.Location = new Point(12, 9);
            sealsCountLabel.Name = "sealsCountLabel";
            sealsCountLabel.Size = new Size(64, 15);
            sealsCountLabel.TabIndex = 0;
            sealsCountLabel.Text = "Seal Count";
            // 
            // brazierSealLabel
            // 
            brazierSealLabel.AutoSize = true;
            brazierSealLabel.ForeColor = Color.Gold;
            brazierSealLabel.Location = new Point(12, 24);
            brazierSealLabel.Name = "brazierSealLabel";
            brazierSealLabel.Size = new Size(42, 15);
            brazierSealLabel.TabIndex = 1;
            brazierSealLabel.Text = "Brazier";
            // 
            // potionSealLabel
            // 
            potionSealLabel.AutoSize = true;
            potionSealLabel.ForeColor = Color.LimeGreen;
            potionSealLabel.Location = new Point(12, 39);
            potionSealLabel.Name = "potionSealLabel";
            potionSealLabel.Size = new Size(42, 15);
            potionSealLabel.TabIndex = 2;
            potionSealLabel.Text = "Potion";
            // 
            // paintingSealLabel
            // 
            paintingSealLabel.AutoSize = true;
            paintingSealLabel.ForeColor = Color.Maroon;
            paintingSealLabel.Location = new Point(12, 54);
            paintingSealLabel.Name = "paintingSealLabel";
            paintingSealLabel.Size = new Size(51, 15);
            paintingSealLabel.TabIndex = 3;
            paintingSealLabel.Text = "Painting";
            // 
            // elementsSealLabel
            // 
            elementsSealLabel.AutoSize = true;
            elementsSealLabel.ForeColor = Color.Crimson;
            elementsSealLabel.Location = new Point(12, 69);
            elementsSealLabel.Name = "elementsSealLabel";
            elementsSealLabel.Size = new Size(50, 15);
            elementsSealLabel.TabIndex = 4;
            elementsSealLabel.Text = "Element";
            // 
            // brazierButton
            // 
            brazierButton.BackColor = Color.WhiteSmoke;
            brazierButton.ForeColor = Color.DarkRed;
            brazierButton.Location = new Point(126, 174);
            brazierButton.Name = "brazierButton";
            brazierButton.Size = new Size(75, 23);
            brazierButton.TabIndex = 5;
            brazierButton.Text = "Braziers";
            brazierButton.UseVisualStyleBackColor = false;
            brazierButton.Click += brazierButton_Click;
            // 
            // potionButton
            // 
            potionButton.BackColor = Color.WhiteSmoke;
            potionButton.ForeColor = Color.DarkRed;
            potionButton.Location = new Point(575, 174);
            potionButton.Name = "potionButton";
            potionButton.Size = new Size(75, 23);
            potionButton.TabIndex = 6;
            potionButton.Text = "Potions";
            potionButton.UseVisualStyleBackColor = false;
            potionButton.Click += potionButton_Click;
            // 
            // paintingButton
            // 
            paintingButton.BackColor = Color.WhiteSmoke;
            paintingButton.ForeColor = Color.DarkRed;
            paintingButton.Location = new Point(234, 174);
            paintingButton.Name = "paintingButton";
            paintingButton.Size = new Size(75, 23);
            paintingButton.TabIndex = 7;
            paintingButton.Text = "Paintings";
            paintingButton.UseVisualStyleBackColor = false;
            paintingButton.Click += paintingButton_Click;
            // 
            // elementsButton
            // 
            elementsButton.BackColor = Color.WhiteSmoke;
            elementsButton.ForeColor = Color.DarkRed;
            elementsButton.Location = new Point(673, 174);
            elementsButton.Name = "elementsButton";
            elementsButton.Size = new Size(75, 23);
            elementsButton.TabIndex = 8;
            elementsButton.Text = "Elements";
            elementsButton.UseVisualStyleBackColor = false;
            elementsButton.Click += elementsButton_Click;
            // 
            // escapeButton
            // 
            escapeButton.BackColor = Color.WhiteSmoke;
            escapeButton.ForeColor = Color.DarkRed;
            escapeButton.Location = new Point(508, 39);
            escapeButton.Name = "escapeButton";
            escapeButton.Size = new Size(75, 23);
            escapeButton.TabIndex = 9;
            escapeButton.Text = "Escape Door";
            escapeButton.UseVisualStyleBackColor = false;
            escapeButton.Click += escapeButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.WhiteSmoke;
            saveButton.ForeColor = Color.DarkRed;
            saveButton.Location = new Point(713, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.BackColor = Color.Transparent;
            infoLabel.ForeColor = Color.Gold;
            infoLabel.Location = new Point(12, 231);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(172, 210);
            infoLabel.TabIndex = 11;
            // 
            // FoyerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(infoLabel);
            Controls.Add(saveButton);
            Controls.Add(escapeButton);
            Controls.Add(elementsButton);
            Controls.Add(paintingButton);
            Controls.Add(potionButton);
            Controls.Add(brazierButton);
            Controls.Add(elementsSealLabel);
            Controls.Add(paintingSealLabel);
            Controls.Add(potionSealLabel);
            Controls.Add(brazierSealLabel);
            Controls.Add(sealsCountLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FoyerForm";
            Text = "FoyerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sealsCountLabel;
        private Label brazierSealLabel;
        private Label potionSealLabel;
        private Label paintingSealLabel;
        private Label elementsSealLabel;
        private Button brazierButton;
        private Button potionButton;
        private Button paintingButton;
        private Button elementsButton;
        private Button escapeButton;
        private Button saveButton;
        private Label infoLabel;
    }
}