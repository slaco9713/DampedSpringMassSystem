using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBall
{
    public partial class Form1 : Form
    {
        private int currentYposition;
        private int stepSize;
        private int maxSteps;
        private int stepNumber;

        private int x;

        private int direction;
        
        /// <summary>
        /// Constructor does some preprocessing to determine step size and initial direction.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            
            maxSteps = 10;
            stepNumber = 1;

            x = football.Location.X;
            currentYposition = football.Location.Y;

            direction = -1;

            int maxY = (upperWall.Location.Y + upperWall.Height);
            int length = football.Location.Y - maxY;
            int steps = 10;

            stepSize = length / steps;
        }

        private void button1_ClickHandler(object sender, EventArgs e)
        {
            if (stepNumber > maxSteps)
            {
                stepNumber = 1;
                direction *= -1;
            }

            currentYposition += direction * stepSize;
            stepNumber++;

            football.Location = new Point(x, currentYposition);
        }
    }
}
