using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public Triangle()
        { }
        public Triangle(double inputa, double inputb, double inputc)
        {
            A = inputa;
            B = inputb;
            C = inputc;
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    Console.WriteLine("Incorrect a");
                }
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Incorrect b");
                }
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value < (b + a))
                {
                    c = value;
                }
                else
                {
                    Console.WriteLine("Incorrect c");
                }
            }
        }
        public double Perimetr()
        {
            return a + b + c;
        }
        public double Square()
        {
            double halfOfPerimetr = Perimetr()/2 ;
            double square = Math.Sqrt(halfOfPerimetr*(halfOfPerimetr-a)*(halfOfPerimetr - b)*(halfOfPerimetr - c));
                return square;
        }
    }
}
