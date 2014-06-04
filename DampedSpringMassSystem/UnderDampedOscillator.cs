using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DampedHarmonicOscillator
{
    public class UnderDampedOscillator
    {
        //m = mass, c = damping coefficient, k = spring constant, t = time
        private double m;
        private double c;
        private double k;
        private double t;
        private double A;
        private double B;
        private double w;
        private double aMax;

        private double period;
        private double deltaT;
        private double n;
        private double currentX;

        public UnderDampedOscillator(double k, double m, double c, double aMax)
        {
            if ((c * c) - (4 * k * m) >= -3.3)
                throw new Exception("(c^2 - 4mk) must be less than zero!!!");
            else if (((2 * k * m) - (c * c)) <= 0)
                throw new Exception("(2mk - c^2) must be greater than zero!!!");

            this.k = k;
            this.m = m;
            this.c = c;
            this.aMax = aMax;

            //TODO: WRITE YOUR CONSTRUCTOR - initialize your variables!!!
            w = Math.Sqrt(4 * m * k - Math.Pow(c, 2)) / (2 * m);
            A = aMax;
            B = (c / (2 * m) * aMax) / w;

            period = 2 * Math.PI / w;
            deltaT = period / 10;
            n = 0;
            currentX = 0;
        }

        public double GetNextSample()
        {
            n += deltaT;
            
            double nextSample = Evaluate(n);
            double nextDelta = nextSample - currentX;
            currentX = nextSample;

            return nextDelta;
        }

        private double Evaluate(double t)
        {
            double gamma = -c / (2 * m);
            double B = Math.Exp(gamma * t);
            double C = Math.Sin(w * t);
            return A * B * C;
        }
    }
}
