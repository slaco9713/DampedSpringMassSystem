using NPlot;
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

        private int maximumZ;
        private int minimumZ;

        private double k;
        private double m;
        private double c;
        private double aMax;

        private int currentLocation;

        private UnderDampedOscillator f;

        private Timer timer;

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

            currentLocation = springXcoord;

            maximumZ = 450;
            minimumZ = 95;

            timer = new Timer();
            timer.Tick += OnTimerElapsed;
            timer.Interval = 100;

            //this is for startSim button click handler
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            //pictureSpring.Size = new Size(springXcoord, springHeight);
            //pictureMass.Location = new Point(massXcoord, massYcoord);

            int nextDelta = Convert.ToInt32(LinearTransformation(f.GetNextSample()));
            currentLocation += nextDelta;

            pictureSpring.Size = new Size(currentLocation, springHeight);
            pictureMass.Location = new Point(currentLocation, massYcoord);
        }

        private double LinearTransformation(double deltaX)
        { 
            return ((maximumZ - minimumZ) / (2*aMax)) * deltaX;
        }

        private void button_startSim_Click(object sender, EventArgs e)
        {
            k = Convert.ToDouble(stiffness.Text);
            m = Convert.ToDouble(mass.Text);
            c = Convert.ToDouble(dampingCoeff.Text);
            aMax = Convert.ToDouble(max_x.Text);

            f = new UnderDampedOscillator(k, m, c, aMax);

            timer.Start();
        }

        private void OnTimerElapsed(Object source, EventArgs e)
        {
            DoInUIThread();
        }

        private void DoInUIThread()
        {
            int nextDelta = Convert.ToInt32(LinearTransformation(f.GetNextSample()));
            currentLocation += nextDelta;

            pictureSpring.Size = new Size(currentLocation, springHeight);
            pictureMass.Location = new Point(currentLocation, massYcoord);
        }

    }
}
