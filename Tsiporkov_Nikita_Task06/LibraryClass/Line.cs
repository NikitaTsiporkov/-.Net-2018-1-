using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace LibraryClass
{
    public class Line : IFigure
    {
        public string Name => "Line";
        private Point point1;
        Point point2;
        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public void Draw(ICanvas canvas)
        {
            canvas.DrawLine(point1,point2);
        }
    }
}