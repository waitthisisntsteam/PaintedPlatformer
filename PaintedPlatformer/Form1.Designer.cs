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
            InRangeCalibrationButton = new Button();
            ErosionBar = new TrackBar();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            StepFourCheck = new CheckBox();
            ErosionButton = new Button();
            StartGameButton = new Button();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)VideoCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarpedCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErosionBar).BeginInit();
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
            MinB.Location = new Point(561, 280);
            MinB.Maximum = 255;
            MinB.Name = "MinB";
            MinB.Size = new Size(104, 45);
            MinB.TabIndex = 4;
            // 
            // TakePhotoButton
            // 
            TakePhotoButton.Location = new Point(566, 107);
            TakePhotoButton.Name = "TakePhotoButton";
            TakePhotoButton.Size = new Size(85, 32);
            TakePhotoButton.TabIndex = 10;
            TakePhotoButton.Text = "Take Photo";
            TakePhotoButton.UseVisualStyleBackColor = true;
            TakePhotoButton.Click += TakePhotoButton_Click;
            // 
            // RetryPhotoButton
            // 
            RetryPhotoButton.Location = new Point(657, 107);
            RetryPhotoButton.Name = "RetryPhotoButton";
            RetryPhotoButton.Size = new Size(85, 32);
            RetryPhotoButton.TabIndex = 11;
            RetryPhotoButton.Text = "Retry Photo";
            RetryPhotoButton.UseVisualStyleBackColor = true;
            RetryPhotoButton.Click += RetryPhotoButton_Click;
            // 
            // StepOneCheck
            // 
            StepOneCheck.AutoSize = true;
            StepOneCheck.Enabled = false;
            StepOneCheck.Location = new Point(830, 84);
            StepOneCheck.Name = "StepOneCheck";
            StepOneCheck.Size = new Size(15, 14);
            StepOneCheck.TabIndex = 12;
            StepOneCheck.UseVisualStyleBackColor = true;
            // 
            // MinG
            // 
            MinG.Location = new Point(561, 331);
            MinG.Maximum = 255;
            MinG.Name = "MinG";
            MinG.Size = new Size(104, 45);
            MinG.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 84);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 14;
            label1.Text = "Step One:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 262);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 15;
            label2.Text = "Min B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 310);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 16;
            label3.Text = "Min G:";
            // 
            // MinR
            // 
            MinR.Location = new Point(561, 382);
            MinR.Maximum = 255;
            MinR.Name = "MinR";
            MinR.Size = new Size(104, 45);
            MinR.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 364);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 18;
            label4.Text = "Min R:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(663, 364);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 24;
            label5.Text = "Max V:";
            // 
            // MaxV
            // 
            MaxV.Location = new Point(653, 382);
            MaxV.Maximum = 255;
            MaxV.Name = "MaxV";
            MaxV.Size = new Size(104, 45);
            MaxV.TabIndex = 23;
            MaxV.Value = 255;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 310);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 22;
            label6.Text = "Max S:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(663, 262);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 21;
            label7.Text = "Max H:";
            // 
            // MaxS
            // 
            MaxS.Location = new Point(653, 331);
            MaxS.Maximum = 255;
            MaxS.Name = "MaxS";
            MaxS.Size = new Size(104, 45);
            MaxS.TabIndex = 20;
            MaxS.Value = 210;
            // 
            // MaxH
            // 
            MaxH.Location = new Point(653, 280);
            MaxH.Maximum = 360;
            MaxH.Name = "MaxH";
            MaxH.Size = new Size(104, 45);
            MaxH.TabIndex = 19;
            MaxH.Value = 360;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(551, 142);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 25;
            label8.Text = "Step Two:";
            // 
            // StepTwoCheck
            // 
            StepTwoCheck.AutoSize = true;
            StepTwoCheck.Enabled = false;
            StepTwoCheck.Location = new Point(830, 142);
            StepTwoCheck.Name = "StepTwoCheck";
            StepTwoCheck.Size = new Size(15, 14);
            StepTwoCheck.TabIndex = 26;
            StepTwoCheck.UseVisualStyleBackColor = true;
            // 
            // StepThreeCheck
            // 
            StepThreeCheck.AutoSize = true;
            StepThreeCheck.Enabled = false;
            StepThreeCheck.Location = new Point(830, 224);
            StepThreeCheck.Name = "StepThreeCheck";
            StepThreeCheck.Size = new Size(15, 14);
            StepThreeCheck.TabIndex = 28;
            StepThreeCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(550, 224);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 27;
            label9.Text = "Step Three:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(561, 162);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 29;
            label10.Text = "Click The Corners...";
            // 
            // CornerOneCheck
            // 
            CornerOneCheck.AutoSize = true;
            CornerOneCheck.Enabled = false;
            CornerOneCheck.Location = new Point(646, 183);
            CornerOneCheck.Name = "CornerOneCheck";
            CornerOneCheck.Size = new Size(15, 14);
            CornerOneCheck.TabIndex = 30;
            CornerOneCheck.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(568, 182);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 31;
            label11.Text = "1. Top Left";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(568, 197);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 33;
            label12.Text = "2. Top Right";
            // 
            // CornerTwoCheck
            // 
            CornerTwoCheck.AutoSize = true;
            CornerTwoCheck.Enabled = false;
            CornerTwoCheck.Location = new Point(646, 198);
            CornerTwoCheck.Name = "CornerTwoCheck";
            CornerTwoCheck.Size = new Size(15, 14);
            CornerTwoCheck.TabIndex = 32;
            CornerTwoCheck.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(667, 182);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 35;
            label13.Text = "3. Bottom Left";
            // 
            // CornerThreeCheck
            // 
            CornerThreeCheck.AutoSize = true;
            CornerThreeCheck.Enabled = false;
            CornerThreeCheck.Location = new Point(763, 183);
            CornerThreeCheck.Name = "CornerThreeCheck";
            CornerThreeCheck.Size = new Size(15, 14);
            CornerThreeCheck.TabIndex = 34;
            CornerThreeCheck.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(667, 197);
            label14.Name = "label14";
            label14.Size = new Size(90, 15);
            label14.TabIndex = 37;
            label14.Text = "4. Bottom Right";
            // 
            // CornerFourCheck
            // 
            CornerFourCheck.AutoSize = true;
            CornerFourCheck.Enabled = false;
            CornerFourCheck.Location = new Point(763, 198);
            CornerFourCheck.Name = "CornerFourCheck";
            CornerFourCheck.Size = new Size(15, 14);
            CornerFourCheck.TabIndex = 36;
            CornerFourCheck.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(566, 244);
            label15.Name = "label15";
            label15.Size = new Size(255, 15);
            label15.TabIndex = 38;
            label15.Text = "Adjust until all obstacles are outlined in white...";
            // 
            // InRangeCalibrationButton
            // 
            InRangeCalibrationButton.Location = new Point(621, 413);
            InRangeCalibrationButton.Name = "InRangeCalibrationButton";
            InRangeCalibrationButton.Size = new Size(75, 32);
            InRangeCalibrationButton.TabIndex = 39;
            InRangeCalibrationButton.Text = "Complete";
            InRangeCalibrationButton.UseVisualStyleBackColor = true;
            InRangeCalibrationButton.Click += InRangeCalibrationButton_Click;
            // 
            // ErosionBar
            // 
            ErosionBar.Enabled = false;
            ErosionBar.Location = new Point(607, 512);
            ErosionBar.Name = "ErosionBar";
            ErosionBar.Size = new Size(104, 45);
            ErosionBar.TabIndex = 40;
            ErosionBar.Scroll += ErosionBar_Scroll;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(551, 451);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 41;
            label16.Text = "Step Four:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(568, 473);
            label17.Name = "label17";
            label17.Size = new Size(104, 15);
            label17.TabIndex = 42;
            label17.Text = "Seperate Objects...";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(623, 494);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 43;
            label18.Text = "Gap Space:";
            // 
            // StepFourCheck
            // 
            StepFourCheck.AutoSize = true;
            StepFourCheck.Enabled = false;
            StepFourCheck.Location = new Point(826, 377);
            StepFourCheck.Name = "StepFourCheck";
            StepFourCheck.Size = new Size(15, 14);
            StepFourCheck.TabIndex = 44;
            StepFourCheck.UseVisualStyleBackColor = true;
            // 
            // ErosionButton
            // 
            ErosionButton.Location = new Point(621, 546);
            ErosionButton.Name = "ErosionButton";
            ErosionButton.Size = new Size(75, 32);
            ErosionButton.TabIndex = 45;
            ErosionButton.Text = "Complete";
            ErosionButton.UseVisualStyleBackColor = true;
            ErosionButton.Click += ErosionButton_Click;
            // 
            // StartGameButton
            // 
            StartGameButton.Enabled = false;
            StartGameButton.Location = new Point(603, 599);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(154, 86);
            StartGameButton.TabIndex = 46;
            StartGameButton.Text = "Calibration Complete";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(653, 31);
            label19.Name = "label19";
            label19.Size = new Size(68, 15);
            label19.TabIndex = 47;
            label19.Text = "Calibration:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 721);
            Controls.Add(label19);
            Controls.Add(StartGameButton);
            Controls.Add(ErosionButton);
            Controls.Add(StepFourCheck);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(ErosionBar);
            Controls.Add(InRangeCalibrationButton);
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
            Text = "Painted Platformer Calibration";
            ((System.ComponentModel.ISupportInitialize)VideoCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarpedCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinB).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinG).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxV).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxS).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxH).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErosionBar).EndInit();
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
        private Button InRangeCalibrationButton;
        private TrackBar ErosionBar;
        private Label label16;
        private Label label17;
        private Label label18;
        private CheckBox StepFourCheck;
        private Button ErosionButton;
        private Button StartGameButton;
        private Label label19;
    }
}
