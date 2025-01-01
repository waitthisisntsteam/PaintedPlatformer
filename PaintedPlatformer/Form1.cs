using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using static Emgu.CV.DenseRLOFOpticalFlow;

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

        private int CurrentStep;

        private Point CornerOne;
        private Point CornerTwo;
        private Point CornerThree;
        private Point CornerFour;

        public Form1()
        {
            InitializeComponent();

            Video = new VideoCapture(0);
            Video.Set(CapProp.FrameWidth, 1080);
            Video.Set(CapProp.FrameHeight, 720);
            Video.Set(CapProp.Exposure, -6);

            InputImage = null;
            OutputImage = null;

            CurrentStep = 2;

            Point CornerOne = new Point(0, 0);
            Point CornerTwo = new Point(0, 0);
            Point CornerThree = new Point(0, 0);
            Point CornerFour = new Point(0, 0);

            Application.Idle += Update;
        }

        private void Update(object sender, EventArgs e)
        {
            Mat input = InputImage == null ? new() : InputImage;
            Mat output = OutputImage == null ? new() : OutputImage;

            if (CurrentStep <= 2)
            {
                input = Video.QueryFrame().Clone();
                output = input.Clone();
            }
            else if (CurrentStep == 3)
            {
                if (CornerOneCheck.Checked && CornerTwoCheck.Checked && CornerThreeCheck.Checked && CornerFourCheck.Checked)
                {
                    PointF[] inputPoints = [CornerOne, CornerTwo, CornerThree, CornerFour];
                    PointF[] outputPoints = [new PointF(0, 0), new PointF(WarpedCapture.Width, 0), new PointF(0, WarpedCapture.Height), new PointF(WarpedCapture.Width, WarpedCapture.Height)];
                    using Mat mapMatrix = CvInvoke.GetPerspectiveTransform(inputPoints, outputPoints);
                    CvInvoke.WarpPerspective(input, output, mapMatrix, new Size(1080, 720), Inter.Linear, Warp.Default, BorderType.Constant, default);

                    output = new Mat(output, new Rectangle(0, 0, output.Width / 2, output.Height / 2));


                    InputImage = output;
                    CurrentStep++;
                    StepTwoCheck.Checked = true;
                }
            }
            else if (CurrentStep == 4) CvInvoke.InRange(input, new ScalarArray(new MCvScalar(MinB.Value, MinG.Value, MinR.Value)), new ScalarArray(new MCvScalar(MaxH.Value, MaxS.Value, MaxV.Value)), output);

            VideoCapture.DisplayedImage = input;
            WarpedCapture.DisplayedImage = output;

            //input.Dispose();
            //output.Dispose();
        }

        private void TakePhotoButton_Click(object sender, EventArgs e)
        {
            InputImage = VideoCapture.DisplayedImage as Mat;
            OutputImage = WarpedCapture.DisplayedImage as Mat;

            StepOneCheck.Checked = true;
            CurrentStep++;
        }

        private void RetryPhotoButton_Click(object sender, EventArgs e)
        {
            InputImage.Dispose();
            InputImage = null;

            OutputImage.Dispose();
            OutputImage = null;

            StepOneCheck.Checked = false;
            StepTwoCheck.Checked = false;
            CurrentStep = 2;

            CornerOneCheck.Checked = false;
            CornerTwoCheck.Checked = false;
            CornerThreeCheck.Checked = false;
            CornerFourCheck.Checked = false;
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
            }
        }

        private void ObjectCalibrationButton_Click(object sender, EventArgs e)
        {
            //

            StepThreeCheck.Checked = true;
            CurrentStep++;
        }
    }
}