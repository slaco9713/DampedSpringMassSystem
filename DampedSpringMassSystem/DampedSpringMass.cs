using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DampedHarmonicOscillator
{
    public partial class DampedSpringMass : Form
    {
        private int springXcoord;
        private int massXcoord;

        private int springYcoord;
        private int massYcoord;
        private int springHeight;

        private int direction;

        private int step;
        private int stepSize;

        private int maximumX;
        private int minimumX;

        public DampedSpringMass()
        {
            InitializeComponent();

            //springXcoord defined as top, right corner (rather than default - top, left corner)
            springXcoord = pictureSpring.Location.X + pictureSpring.Size.Width;
            pictureMass.Location = new Point(springXcoord, pictureMass.Location.Y);
            massXcoord = pictureMass.Location.X;

            springYcoord = pictureSpring.Location.Y;
            massYcoord = pictureMass.Location.Y;
            springHeight = pictureSpring.Size.Height;

            direction = 1;

            maximumX = 395;
            minimumX = 95;
            stepSize = (maximumX - minimumX) / 10;
            step = 0;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            //if spring-mass system hasn't reached maximum displacement, continue direction
            if ((direction == 1) && (springXcoord < maximumX))
            {
                direction = 1;
            }
            else if ((direction == -1) && (springXcoord > minimumX))
            {
                direction = -1;
            }

            //if spring location is at (or has exceeded) max / min displacement, change direction
            if (springXcoord >= maximumX)
            {
                direction = -1;
            }
            else if(springXcoord <= minimumX)
            {
                direction = 1;
            }

            //controls  movement of spring-mass system
            if (direction == 1)
            {
                step++;
                springXcoord += stepSize;
                massXcoord = springXcoord;

                pictureSpring.Size = new Size(springXcoord, springHeight);
                pictureMass.Location = new Point(massXcoord, massYcoord);
            }
            else if (direction == -1)
            {
                step++;
                springXcoord -= stepSize;
                massXcoord = springXcoord;

                pictureSpring.Size = new Size(springXcoord, springHeight);
                pictureMass.Location = new Point(massXcoord, massYcoord);
            }

            cycles.Text = step.ToString();
        }


    }
}
