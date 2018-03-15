using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryClass
{
    public class Round : Figure
    {
        protected Point point;
        protected double radius;
        public Round(Point point, double radius)
        {
            this.point = point;
            this.radius = radius;
            if (radius < 0)
            {
                throw new Exception("Invalid radius");
            }
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(point, radius);
        }
    }
}
