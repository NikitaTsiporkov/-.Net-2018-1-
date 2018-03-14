
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task2
{
    class Ring : Round
    {
        private double innerRadius;
        public Ring(double inputx, double inputy, double inputradius, double innerRadius)
            : base(inputx, inputy, inputradius)
        {
            InnerRadius = inputradius;
        }
        public double InnerRadius
        {
            get { return innerRadius; }
            set
            {
                if (value > 0 && value<Radius)
                {
                    innerRadius = value;
                }
                else
                {
                    throw new ArgumentException("Invalid radius");
                }
            }
        }
        public double Square()
        {
            return Square(Radius) - Square(innerRadius);
        }
        public double SumLength(double innerRadius, double radius)
        {
            return Length(innerRadius) + Length(radius);
        }
    }
}