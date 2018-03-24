using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryClass
{
    public class Rect : IFigure
    {
        public string Name => "Rectangle";
        private Point point1;
        private Point point2;
        public Rect(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
            if (point1.X == point2.X || point1.Y == point2.Y)
            {
                throw new Exception("It isn't rectangle");
            }
        }
        public void Draw(ICanvas canvas)
        {
            canvas.DrawRect(point1, point2);
        }
    }
}
