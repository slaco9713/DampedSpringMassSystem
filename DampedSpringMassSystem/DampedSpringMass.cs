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
        private int currentXspring;
        private int currentXmass;
        private int equilibriumPosition;

        private int currentYspring;
        private int currentYmass;
        private int springHeight;

        private int direction;

        private int step;
        private int stepSize;
        private int distance;

        private int maximumX;
        private int minimumX;

        public DampedSpringMass()
        {
            InitializeComponent();

            //initialize the x-coord of spring & mass
            equilibriumPosition = pictureSpring.Location.X + pictureSpring.Size.Width;
            currentXspring = pictureSpring.Location.X + pictureSpring.Size.Width;
            pictureMass.Location = new Point(currentXspring, pictureMass.Location.Y);
            currentXmass = pictureMass.Location.X;

            //constant Y location of spring & mass
            currentYspring = pictureSpring.Location.Y;
            currentYmass = pictureMass.Location.Y;
            springHeight = pictureSpring.Size.Height;

            //initialize direction - note: spring & mass should MOVE TOGETHER ALWAYS!!
            direction = 1;

            //initialize steps & stepSize
   
            step = 0;
            
            maximumX = 395;
            minimumX = 95;

            distance = maximumX - minimumX;
            stepSize = distance / 10;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            //if spring location is between equilib. & maximum, set direction
            //CHANGE ALL OF THESE CONDITIONS - THEY ARE VERY BAD AND ARE SCREWING EVERYHING UP!!!
            if ((direction == 1) && (currentXspring < maximumX))
            {
                direction = 1;
            }
            else if ((direction == -1) && (currentXspring > minimumX))
            {
                direction = -1;
            }

            //if spring location is at (or has exceeded) max / min values, change direction
            if (currentXspring >= maximumX)
            {
                direction = -1;
            }
            else if(currentXspring <= minimumX)
            {
                direction = 1;
            }

            //controls the movement of mass / spring system
            if (direction == 1)
            {
                step++;
                currentXspring += stepSize;
                currentXmass = currentXspring;
                pictureSpring.Size = new Size(currentXspring, springHeight);
                pictureMass.Location = new Point(currentXmass, currentYmass);
            }
            else if (direction == -1)
            {
                step++;
                currentXspring -= stepSize;
                currentXmass = currentXspring;
                pictureSpring.Size = new Size(currentXspring, springHeight);
                pictureMass.Location = new Point(currentXmass, currentYmass);
            }

            cycles.Text = step.ToString();
        }


    }
}
