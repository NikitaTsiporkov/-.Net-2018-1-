﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private double radius;
        private const double pi = Math.PI;
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
            get;
            set;
        }
        public double Y
        {
            get;
            set;
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
                return pi * radius;
            }
        }
    }
}
