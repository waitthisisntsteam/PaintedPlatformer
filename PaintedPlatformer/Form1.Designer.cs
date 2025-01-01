namespace PaintedPlatformer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            VideoCapture = new Emgu.CV.UI.ImageBox();
            WarpedCapture = new Emgu.CV.UI.ImageBox();
            MinB = new TrackBar();
            TakePhotoButton = new Button();
            RetryPhotoButton = new Button();
            StepOneCheck = new CheckBox();
            MinG = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MinR = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            MaxV = new TrackBar();
            label6 = new Label();
            label7 = new Label();
            MaxS = new TrackBar();
            MaxH = new TrackBar();
            label8 = new Label();
            StepTwoCheck = new CheckBox();
            StepThreeCheck = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            CornerOneCheck = new CheckBox();
            label11 = new Label();
            label12 = new Label();
            CornerTwoCheck = new CheckBox();
            label13 = new Label();
            CornerThreeCheck = new CheckBox();
            label14 = new Label();
            CornerFourCheck = new CheckBox();
            label15 = new Label();
            ObjectCalibrationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)VideoCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarpedCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxH).BeginInit();
            SuspendLayout();
            // 
            // VideoCapture
            // 
            VideoCapture.Location = new Point(0, 0);
            VideoCapture.Name = "VideoCapture";
            VideoCapture.Size = new Size(540, 360);
            VideoCapture.SizeMode = PictureBoxSizeMode.StretchImage;
            VideoCapture.TabIndex = 2;
            VideoCapture.TabStop = false;
            VideoCapture.Click += VideoCapture_Click;
            // 
            // WarpedCapture
            // 
            WarpedCapture.Location = new Point(0, 366);
            WarpedCapture.Name = "WarpedCapture";
            WarpedCapture.Size = new Size(540, 360);
            WarpedCapture.SizeMode = PictureBoxSizeMode.StretchImage;
            WarpedCapture.TabIndex = 3;
            WarpedCapture.TabStop = false;
            // 
            // MinB
            // 
            MinB.Location = new Point(557, 205);
            MinB.Maximum = 255;
            MinB.Name = "MinB";
            MinB.Size = new Size(104, 45);
            MinB.TabIndex = 4;
            // 
            // TakePhotoButton
            // 
            TakePhotoButton.Location = new Point(562, 32);
            TakePhotoButton.Name = "TakePhotoButton";
            TakePhotoButton.Size = new Size(85, 23);
            TakePhotoButton.TabIndex = 10;
            TakePhotoButton.Text = "Take Photo";
            TakePhotoButton.UseVisualStyleBackColor = true;
            TakePhotoButton.Click += TakePhotoButton_Click;
            // 
            // RetryPhotoButton
            // 
            RetryPhotoButton.Location = new Point(653, 32);
            RetryPhotoButton.Name = "RetryPhotoButton";
            RetryPhotoButton.Size = new Size(85, 23);
            RetryPhotoButton.TabIndex = 11;
            RetryPhotoButton.Text = "Retry Photo";
            RetryPhotoButton.UseVisualStyleBackColor = true;
            RetryPhotoButton.Click += RetryPhotoButton_Click;
            // 
            // StepOneCheck
            // 
            StepOneCheck.AutoSize = true;
            StepOneCheck.Enabled = false;
            StepOneCheck.Location = new Point(826, 9);
            StepOneCheck.Name = "StepOneCheck";
            StepOneCheck.Size = new Size(15, 14);
            StepOneCheck.TabIndex = 12;
            StepOneCheck.UseVisualStyleBackColor = true;
            // 
            // MinG
            // 
            MinG.Location = new Point(557, 256);
            MinG.Maximum = 255;
            MinG.Name = "MinG";
            MinG.Size = new Size(104, 45);
            MinG.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 14;
            label1.Text = "Step One:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 187);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 15;
            label2.Text = "Min B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 235);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 16;
            label3.Text = "Min G:";
            // 
            // MinR
            // 
            MinR.Location = new Point(557, 307);
            MinR.Maximum = 255;
            MinR.Name = "MinR";
            MinR.Size = new Size(104, 45);
            MinR.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(567, 289);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 18;
            label4.Text = "Min R:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(659, 289);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 24;
            label5.Text = "Max V:";
            // 
            // MaxV
            // 
            MaxV.Location = new Point(649, 307);
            MaxV.Maximum = 255;
            MaxV.Name = "MaxV";
            MaxV.Size = new Size(104, 45);
            MaxV.TabIndex = 23;
            MaxV.Value = 255;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(659, 235);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 22;
            label6.Text = "Max S:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 187);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 21;
            label7.Text = "Max H:";
            // 
            // MaxS
            // 
            MaxS.Location = new Point(649, 256);
            MaxS.Maximum = 255;
            MaxS.Name = "MaxS";
            MaxS.Size = new Size(104, 45);
            MaxS.TabIndex = 20;
            MaxS.Value = 255;
            // 
            // MaxH
            // 
            MaxH.Location = new Point(649, 205);
            MaxH.Maximum = 255;
            MaxH.Name = "MaxH";
            MaxH.Size = new Size(104, 45);
            MaxH.TabIndex = 19;
            MaxH.Value = 255;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(547, 67);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 25;
            label8.Text = "Step Two:";
            // 
            // StepTwoCheck
            // 
            StepTwoCheck.AutoSize = true;
            StepTwoCheck.Enabled = false;
            StepTwoCheck.Location = new Point(826, 67);
            StepTwoCheck.Name = "StepTwoCheck";
            StepTwoCheck.Size = new Size(15, 14);
            StepTwoCheck.TabIndex = 26;
            StepTwoCheck.UseVisualStyleBackColor = true;
            // 
            // StepThreeCheck
            // 
            StepThreeCheck.AutoSize = true;
            StepThreeCheck.Enabled = false;
            StepThreeCheck.Location = new Point(826, 149);
            StepThreeCheck.Name = "StepThreeCheck";
            StepThreeCheck.Size = new Size(15, 14);
            StepThreeCheck.TabIndex = 28;
            StepThreeCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(546, 149);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 27;
            label9.Text = "Step Three:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(557, 87);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 29;
            label10.Text = "Click The Corners...";
            // 
            // CornerOneCheck
            // 
            CornerOneCheck.AutoSize = true;
            CornerOneCheck.Enabled = false;
            CornerOneCheck.Location = new Point(642, 108);
            CornerOneCheck.Name = "CornerOneCheck";
            CornerOneCheck.Size = new Size(15, 14);
            CornerOneCheck.TabIndex = 30;
            CornerOneCheck.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(564, 107);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 31;
            label11.Text = "1. Top Left";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(564, 122);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 33;
            label12.Text = "2. Top Right";
            // 
            // CornerTwoCheck
            // 
            CornerTwoCheck.AutoSize = true;
            CornerTwoCheck.Enabled = false;
            CornerTwoCheck.Location = new Point(642, 123);
            CornerTwoCheck.Name = "CornerTwoCheck";
            CornerTwoCheck.Size = new Size(15, 14);
            CornerTwoCheck.TabIndex = 32;
            CornerTwoCheck.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(663, 107);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 35;
            label13.Text = "3. Bottom Left";
            // 
            // CornerThreeCheck
            // 
            CornerThreeCheck.AutoSize = true;
            CornerThreeCheck.Enabled = false;
            CornerThreeCheck.Location = new Point(759, 108);
            CornerThreeCheck.Name = "CornerThreeCheck";
            CornerThreeCheck.Size = new Size(15, 14);
            CornerThreeCheck.TabIndex = 34;
            CornerThreeCheck.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(663, 122);
            label14.Name = "label14";
            label14.Size = new Size(90, 15);
            label14.TabIndex = 37;
            label14.Text = "4. Bottom Right";
            // 
            // CornerFourCheck
            // 
            CornerFourCheck.AutoSize = true;
            CornerFourCheck.Enabled = false;
            CornerFourCheck.Location = new Point(759, 123);
            CornerFourCheck.Name = "CornerFourCheck";
            CornerFourCheck.Size = new Size(15, 14);
            CornerFourCheck.TabIndex = 36;
            CornerFourCheck.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(562, 169);
            label15.Name = "label15";
            label15.Size = new Size(255, 15);
            label15.TabIndex = 38;
            label15.Text = "Adjust until all obstacles are outlined in white...";
            // 
            // ObjectCalibrationButton
            // 
            ObjectCalibrationButton.Location = new Point(617, 338);
            ObjectCalibrationButton.Name = "ObjectCalibrationButton";
            ObjectCalibrationButton.Size = new Size(75, 23);
            ObjectCalibrationButton.TabIndex = 39;
            ObjectCalibrationButton.Text = "Complete";
            ObjectCalibrationButton.UseVisualStyleBackColor = true;
            ObjectCalibrationButton.Click += ObjectCalibrationButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 721);
            Controls.Add(ObjectCalibrationButton);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(CornerFourCheck);
            Controls.Add(label13);
            Controls.Add(CornerThreeCheck);
            Controls.Add(label12);
            Controls.Add(CornerTwoCheck);
            Controls.Add(label11);
            Controls.Add(CornerOneCheck);
            Controls.Add(label10);
            Controls.Add(StepThreeCheck);
            Controls.Add(label9);
            Controls.Add(StepTwoCheck);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(MaxV);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(MaxS);
            Controls.Add(MaxH);
            Controls.Add(label4);
            Controls.Add(MinR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MinG);
            Controls.Add(StepOneCheck);
            Controls.Add(RetryPhotoButton);
            Controls.Add(TakePhotoButton);
            Controls.Add(MinB);
            Controls.Add(WarpedCapture);
            Controls.Add(VideoCapture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Painted Platformer";
            ((System.ComponentModel.ISupportInitialize)VideoCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarpedCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinB).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinG).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxV).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxS).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox VideoCapture;
        private Emgu.CV.UI.ImageBox WarpedCapture;
        private TrackBar MinB;
        private Button TakePhotoButton;
        private Button RetryPhotoButton;
        private CheckBox StepOneCheck;
        private TrackBar MinG;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar MinR;
        private Label label4;
        private Label label5;
        private TrackBar MaxV;
        private Label label6;
        private Label label7;
        private TrackBar MaxS;
        private TrackBar MaxH;
        private Label label8;
        private CheckBox StepTwoCheck;
        private CheckBox StepThreeCheck;
        private Label label9;
        private Label label10;
        private CheckBox CornerOneCheck;
        private Label label11;
        private Label label12;
        private CheckBox CornerTwoCheck;
        private Label label13;
        private CheckBox CornerThreeCheck;
        private Label label14;
        private CheckBox CornerFourCheck;
        private Label label15;
        private Button ObjectCalibrationButton;
    }
}
