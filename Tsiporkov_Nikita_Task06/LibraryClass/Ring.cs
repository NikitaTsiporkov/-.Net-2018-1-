using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryClass
{
    public class Ring : Round
    {
        private double radius2;
        public Ring(Point point, double radius1, double radius2) : base(point, radius1)
        {
            this.radius2 = radius2;
            if (!(radius2 > 0 && radius2 < radius))
            {
                throw new Exception("Invalid inner radius");
            }
        }
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(point, radius);
            canvas.DrawRound(point, radius2);
        }

    }
}
