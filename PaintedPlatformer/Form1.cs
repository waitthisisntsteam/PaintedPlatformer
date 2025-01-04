using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;
using static Emgu.CV.DenseRLOFOpticalFlow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace PaintedPlatformer
{
    public partial class Form1 : Form
    {
        //bounds:     //cam:
        //0, 0        //0, 0
        //965, 550    //1080, 720

        //^^ dont understand why its different

        private VideoCapture Video;
        private Mat? InputImage;
        private Mat? OutputImage;

        private Mat GameImage;

        private int CurrentStep;

        private Point CornerOne;
        private Point CornerTwo;
        private Point CornerThree;
        private Point CornerFour;

        private List<Rectangle> ThinPlatforms;
        private List<Rectangle> Platforms;
        private List<Rectangle> Spikes;

        public Form1()
        {
            InitializeComponent();

            Video = new VideoCapture(0);
            Video.Set(CapProp.FrameWidth, 1080);
            Video.Set(CapProp.FrameHeight, 720);
            Video.Set(CapProp.Exposure, -6);

            InputImage = null;
            OutputImage = null;

            CurrentStep = 1;

            Point CornerOne = new Point(0, 0);
            Point CornerTwo = new Point(0, 0);
            Point CornerThree = new Point(0, 0);
            Point CornerFour = new Point(0, 0);

            ThinPlatforms = new();
            Platforms = new();
            Spikes = new();

            Application.Idle += Update;
        }

        private void Update(object sender, EventArgs e)
        {
            if (CurrentStep < 10)
            {
                Mat input = InputImage == null ? new() : InputImage;
                Mat output = OutputImage == null ? new() : OutputImage;

                if (CurrentStep == 1)
                {
                    input = Video.QueryFrame();
                    output = input.Clone();
                }
                else if (CurrentStep == 2)
                {
                    if (CornerOneCheck.Checked && CornerTwoCheck.Checked && CornerThreeCheck.Checked && CornerFourCheck.Checked)
                    {
                        PointF[] inputPoints = [CornerOne, CornerTwo, CornerThree, CornerFour];
                        PointF[] outputPoints = [new PointF(0, 0), new PointF(WarpedCapture.Width, 0), new PointF(0, WarpedCapture.Height), new PointF(WarpedCapture.Width, WarpedCapture.Height)];
                        using Mat mapMatrix = CvInvoke.GetPerspectiveTransform(inputPoints, outputPoints);
                        CvInvoke.WarpPerspective(input, output, mapMatrix, new Size(1080, 720), Inter.Linear, Warp.Default, BorderType.Constant, default);

                        output = new Mat(output, new Rectangle(0, 0, output.Width / 2, output.Height / 2));
                        GameImage = output.Clone();

                        InputImage = output.Clone();
                        CurrentStep++;
                        StepTwoCheck.Checked = true;
                    }
                }
                else if (CurrentStep == 3) CvInvoke.InRange(input, new ScalarArray(new MCvScalar(MinB.Value, MinG.Value, MinR.Value)), new ScalarArray(new MCvScalar(MaxH.Value, MaxS.Value, MaxV.Value)), output);
                else if (CurrentStep == 4)
                {
                    if (!ErosionBar.Enabled) InputImage = OutputImage.Clone();
                    ErosionBar.Enabled = true;
                }
                else if (CurrentStep == 5)
                {
                    using VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                    using Mat heirarchy = new();
                    CvInvoke.FindContours(input, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

                    for (int i = 0; i < contours.Size; i++) CvInvoke.ApproxPolyDP(contours[i], contours[i], 0.01 * CvInvoke.ArcLength(contours[i], true), true);

                    for (int i = 0; i < contours.Size; i++)
                    {
                        Rectangle hitbox = CvInvoke.BoundingRectangle(contours[i]);

                        if (contours[i].Size <= 2) ThinPlatforms.Add(hitbox);
                        else if (contours[i].Size == 4) Platforms.Add(hitbox);
                        else
                        {
                            double triangleArea = Math.Abs(CvInvoke.MinEnclosingTriangle(contours[i], contours[i]));
                            double contourArea = Math.Abs(CvInvoke.ContourArea(contours[i], true));

                            if (contourArea + (triangleArea - contourArea) <= triangleArea)
                            {
                                hitbox = new Rectangle(hitbox.X + hitbox.Width / 2 - hitbox.Width / 4, hitbox.Y + hitbox.Height / 2 - hitbox.Height / 4, hitbox.Width / 2, hitbox.Height / 2);
                                Spikes.Add(hitbox);
                            }
                        }
                    }
                    CurrentStep++;
                    StartGameButton.Enabled = true;
                }
                else if (CurrentStep == 6)
                {
                    for (int i = 0; i < ThinPlatforms.Count; i++) CvInvoke.Rectangle(output, ThinPlatforms[i], new MCvScalar(100, 0, 100), 0);
                    for (int i = 0; i < Platforms.Count; i++) CvInvoke.Rectangle(output, Platforms[i], new MCvScalar(100, 0, 100), 0);
                    for (int i = 0; i < Spikes.Count; i++) CvInvoke.Rectangle(output, Spikes[i], new MCvScalar(100, 0, 100), 0);
                    OutputImage = output;
                }

                VideoCapture.DisplayedImage = input;
                WarpedCapture.DisplayedImage = output;

                //input.Dispose();
                //output.Dispose();
            }
        }

        private void TakePhotoButton_Click(object sender, EventArgs e)
        {
            InputImage = (VideoCapture.DisplayedImage as Mat).Clone();
            OutputImage = (WarpedCapture.DisplayedImage as Mat).Clone();

            TakePhotoButton.Enabled = false;

            VideoCapture.Enabled = true;
            StepOneCheck.Checked = true;
            CurrentStep++;
        }

        private void RetryPhotoButton_Click(object sender, EventArgs e)
        {
            InputImage?.Dispose();
            InputImage = null;

            OutputImage?.Dispose();
            OutputImage = null;

            CurrentStep = 1;

            CornerOne = new Point(0, 0);
            CornerTwo = new Point(0, 0);
            CornerThree = new Point(0, 0);
            CornerFour = new Point(0, 0);

            ThinPlatforms = new();
            Platforms = new();
            Spikes = new();

            StepOneCheck.Checked = false;
            StepTwoCheck.Checked = false;
            StepThreeCheck.Checked = false;
            StepFourCheck.Checked = false;

            CurrentStep = 1;

            VideoCapture.Enabled = false;

            CornerOneCheck.Checked = false;
            CornerTwoCheck.Checked = false;
            CornerThreeCheck.Checked = false;
            CornerFourCheck.Checked = false;

            ErosionBar.Enabled = false;

            TakePhotoButton.Enabled = true;
            InRangeCalibrationButton.Enabled = false;
            ErosionButton.Enabled = false;
            StartGameButton.Enabled = false;
        }

        private void VideoCapture_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs)e;
            int mouseX = me.X;
            int mouseY = me.Y;
            int matX = mouseX * OutputImage.Width / VideoCapture.Width;
            int matY = mouseY * OutputImage.Height / VideoCapture.Height;

            if (!CornerOneCheck.Checked)
            {
                CornerOne = new Point(matX, matY);
                CvInvoke.Circle(OutputImage, CornerOne, 5, new MCvScalar(0, 255, 0), 5);
                CornerOneCheck.Checked = true;
            }
            else if (!CornerTwoCheck.Checked)
            {
                CornerTwo = new Point(matX, matY);
                CvInvoke.Circle(OutputImage, CornerTwo, 5, new MCvScalar(0, 255, 0), 5);
                CornerTwoCheck.Checked = true;
            }
            else if (!CornerThreeCheck.Checked)
            {
                CornerThree = new Point(matX, matY);
                CvInvoke.Circle(OutputImage, CornerThree, 5, new MCvScalar(0, 255, 0), 5);
                CornerThreeCheck.Checked = true;
            }
            else if (!CornerFourCheck.Checked)
            {
                CornerFour = new Point(matX, matY);
                CvInvoke.Circle(OutputImage, CornerFour, 5, new MCvScalar(0, 255, 0), 5);
                CornerFourCheck.Checked = true;

                MinB.Enabled = true;
                MinG.Enabled = true;
                MinR.Enabled = true;

                MaxH.Enabled = true;
                MaxS.Enabled = true;
                MaxV.Enabled = true;

                InRangeCalibrationButton.Enabled = true;
            }
        }

        private void InRangeCalibrationButton_Click(object sender, EventArgs e)
        {
            InputImage = OutputImage.Clone();
            OutputImage = InputImage.Clone();

            StepThreeCheck.Checked = true;
            ErosionBar.Enabled = true;
            ErosionButton.Enabled = true;

            CurrentStep++;
        }

        private void ErosionBar_Scroll(object sender, EventArgs e)
        {
            using Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
            CvInvoke.Erode(InputImage, OutputImage, element, new Point(-1, -1), ErosionBar.Value, BorderType.Constant, new MCvScalar(255, 255, 255));
        }

        private void ErosionButton_Click(object sender, EventArgs e) => CurrentStep++;

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            var gameForm = new Game(GameImage, ThinPlatforms, Platforms, Spikes);
            
            gameForm.Show();
        }
    }
}