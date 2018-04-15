using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }
        public override int GetHashCode()
        {
            //string x1;
            //string y1;
            //string z;
            //if (x < 0)
            //{
            //    x1 = (((-x) * 100 - 10000).ToString());
            //    if (y < 0)
            //    {
            //        y1 = ((-y) * 10).ToString();
            //    }
            //    else
            //    {
            //        y1 = y.ToString();
            //    }
            //}
            //else
            //{
            //    x1 = (x * 100 - 10000).ToString();
            //    if (y < 0)
            //    {
            //        y1 = ((-y) * 1).ToString();
            //    }
            //    else
            //    {
            //        y1 = y.ToString();
            //    }
            //}
            //z = x1 + y1;
            //return int.Parse(z);
            //int z = 0;
            //if (x >= 0 && y >= 0)
            //{
            //    z = x * 100000 + y;
            //}
            //if (x < 0 && y < 0)
            //{
            //    z = x * 100000 + y;
            //}
            //if (x >= 0 && y < 0)
            //{
            //    z = y * 100000 + x * 10;
            //}
            //if (x < 0 && y >= 0)
            //{
            //    z = y * 100000 + x * 10;
            //}
            //return z;
            return (x&1023)+(y&1023);
        }
    }
}
