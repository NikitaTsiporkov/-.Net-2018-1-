using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        protected double radius;
        private const double pi = Math.PI;
        protected double x;
        protected double y;
        public Round(double inputx, double inputy, double inputradius)
        {
            X = inputx;
            Y = inputy;
            Radius = inputradius;
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Incorrect radius");
                }
            }
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double Length(double radius)
        {
                return 2 * pi * radius;
        }
        public double Square(double radius)
        {
                return pi * radius*radius;
        }
    }
}
