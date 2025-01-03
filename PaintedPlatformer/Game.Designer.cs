namespace PaintedPlatformer
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            GameDisplay = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)GameDisplay).BeginInit();
            SuspendLayout();
            // 
            // GameDisplay
            // 
            GameDisplay.Location = new Point(0, 0);
            GameDisplay.Name = "GameDisplay";
            GameDisplay.Size = new Size(540, 360);
            GameDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            GameDisplay.TabIndex = 2;
            GameDisplay.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 360);
            Controls.Add(GameDisplay);
            Name = "Game";
            Text = "Painted Platformer";
            ((System.ComponentModel.ISupportInitialize)GameDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox GameDisplay;
    }
}