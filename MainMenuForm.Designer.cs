namespace EscapefromWithin
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            startButton = new Button();
            loadButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.Transparent;
            startButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            startButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Location = new Point(244, 312);
            startButton.Name = "startButton";
            startButton.Size = new Size(118, 23);
            startButton.TabIndex = 0;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.Transparent;
            loadButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            loadButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Location = new Point(432, 312);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(121, 23);
            loadButton.TabIndex = 1;
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(loadButton);
            Controls.Add(startButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            Text = "EscapefromWithin";
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button loadButton;
    }
}
