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
using Microsoft.VisualBasic.Devices;

namespace PaintedPlatformer
{
    public partial class Game : Form
    {
        private Mat GameImage;

        private List<Rectangle> ThinPlatforms;
        private List<Rectangle> Platforms;
        private List<Rectangle> Spikes;

        private Rectangle Character;
        private int Gravity;
        private bool IncreaseGravity;

        private HashSet<Keys> KeysDown;
        private bool InJump;
        private int JumpDelta;

        public Game(Mat gameImage, List<Rectangle> thinPlatforms, List<Rectangle> platforms, List<Rectangle> spikes)
        {
            InitializeComponent();

            GameImage = gameImage;

            ThinPlatforms = thinPlatforms;
            Platforms = platforms;
            Spikes = spikes;

            Character = new Rectangle(50, 0, 20, 20);

            GameDisplay.DisplayedImage = gameImage.Clone();

            Application.Idle += Update;
            Gravity = 1;
            IncreaseGravity = true;

            KeysDown = new();
            InJump = false;
        }

        private void Update(object sender, EventArgs e)
        {
            using Mat input = GameImage.Clone();
            CvInvoke.Rectangle(input, Character, new MCvScalar(0, 255, 0), 5);

            foreach (Keys key in KeysDown)
            {
                if (key == Keys.D) Character.X += 1;
                if (key == Keys.A) Character.X -= 1;

                if (key == Keys.S) Character.Y += Gravity;
                if (key == Keys.W)
                {
                    JumpDelta = 0;
                    InJump = true;
                }
            }

            if (InJump && JumpDelta < 20)
            {
                Character.Y -= 1;
                JumpDelta += 1;
            }
            else if (JumpDelta >= 20) InJump = false;

            foreach (Rectangle hb in ThinPlatforms)
            {
                if (hb.IntersectsWith(Character))
                {
                    if (Character.Bottom >= hb.Top && Character.Left >= hb.Left && Character.Right <= hb.Right)
                    {
                        Character.Y -= Gravity;
                        IncreaseGravity = false;
                        Gravity = 1;
                    }
                }
            }
            foreach (Rectangle hb in Platforms)
            {
                if (hb.IntersectsWith(Character))
                {
                    if (Character.Bottom >= hb.Top && Character.Left >= hb.Left && Character.Right <= hb.Right)
                    {
                        Character.Y -= Gravity;
                        IncreaseGravity = false;
                        Gravity = 1;
                    }
                }
            }
            foreach (Rectangle hb in Spikes)
            {
                if (hb.IntersectsWith(Character))
                {
                    Character.Location = new Point(0, 0);
                }
            }

            if (Character.Y >= GameDisplay.Bottom)
            {
                Character.Location = new Point(0, 0);
            }

            if (Gravity > 20 && !InJump) IncreaseGravity = false;

            //if (IncreaseGravity) Gravity *= 2;

            if (!InJump) Character.Y += Gravity;

            GameDisplay.DisplayedImage = input;

            //input.Dispose();
            IncreaseGravity = true;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyDown = e.KeyData;
            if (!KeysDown.Contains(keyDown)) KeysDown.Add(keyDown);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            Keys keyDown = e.KeyData;
            if (KeysDown.Contains(keyDown)) KeysDown.Remove(keyDown);
        }
    }
}
