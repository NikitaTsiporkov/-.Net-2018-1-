using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    class Line 
    {
        public Line(double beginX, double beginY, double endX, double endY)
        {
            BeginX = beginX;
            BeginY = beginY;
            EndX = endX;
            EndY = endY;
        }
        public double BeginX
        {
            get;
            set;
        }
        public double BeginY
        {
            get;
            set;
        }
        public double EndX
        {
            get;
            set;
        }
        public double EndY
        {
            get;
            set;
        }
    }
}