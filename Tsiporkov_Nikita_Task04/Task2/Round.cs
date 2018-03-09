using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private double radius;
        private const double pi = 3.14;
        private double x;
        private double y;
        public Round()
        { }
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
        public double Length
        {
            get
            {
                return 2 * pi * radius;
            }
        }
        public double Square
        {
            get
            {
                return pi * pi * radius;
            }
        }
    }
}
