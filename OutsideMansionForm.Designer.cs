namespace EscapefromWithin
{
    partial class OutsideMansionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutsideMansionForm));
            infoLabel = new Label();
            doorButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.BackColor = Color.Transparent;
            infoLabel.ForeColor = Color.DarkRed;
            infoLabel.Location = new Point(12, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(211, 208);
            infoLabel.TabIndex = 0;
            // 
            // doorButton
            // 
            doorButton.BackColor = Color.WhiteSmoke;
            doorButton.ForeColor = Color.DarkRed;
            doorButton.Location = new Point(358, 210);
            doorButton.Name = "doorButton";
            doorButton.Size = new Size(98, 23);
            doorButton.TabIndex = 1;
            doorButton.Text = "Approach Door";
            doorButton.UseVisualStyleBackColor = false;
            doorButton.Click += doorButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.WhiteSmoke;
            saveButton.ForeColor = Color.DarkRed;
            saveButton.Location = new Point(691, 405);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // OutsideMansionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(doorButton);
            Controls.Add(infoLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OutsideMansionForm";
            Text = "OutsideMansionForm";
            ResumeLayout(false);
        }

        #endregion

        private Label infoLabel;
        private Button doorButton;
        private Button saveButton;
    }
}