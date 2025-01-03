using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Game : Form
    {
        List<Rectangle> ThinPlatforms;
        List<Rectangle> Platforms;
        List<Rectangle> Spikes;

        Rectangle Character;

        public Game(Mat gameImage, List<Rectangle> thinPlatforms, List<Rectangle> platforms, List<Rectangle> spikes)
        {
            InitializeComponent();

            ThinPlatforms = thinPlatforms;
            Platforms = platforms;
            Spikes = spikes;

            Character = new Rectangle(0, 0, 20, 50);

            GameDisplay.DisplayedImage = gameImage;

            Application.Idle += Update;
        }

        private void Update(object sender, EventArgs e)
        {

        }
    }
}
