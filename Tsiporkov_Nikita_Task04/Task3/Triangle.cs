using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public Triangle()
        { }
        public Triangle(double inputa, double inputb, double inputc)
        {
            if (inputa > 0 && inputa > (inputb + inputc) && inputb > 0 && inputb > (inputa + inputc) &&
                inputc > 0 && inputc > (inputa + inputc))
            {
                A = inputa;
                B = inputb;
                C = inputc;
            }
            else
            {
                throw new ArgumentException("Not triangle");
            }
        }
        public double A
        {
            get;
            private set;
        }
        public double B
        {
            get;
            private set;
        }
        public double C
        {
            get;
            private set;
        }
        public double Perimetr()
        {
            return A + B + C;
        }
        public double Square()
        {
            double halfOfPerimetr = Perimetr()/2 ;
            double square = Math.Sqrt(halfOfPerimetr*(halfOfPerimetr-A)*(halfOfPerimetr - B)*(halfOfPerimetr - C));
                return square;
        }
    }
}
