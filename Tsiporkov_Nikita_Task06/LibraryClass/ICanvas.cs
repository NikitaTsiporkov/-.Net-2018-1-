using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryClass
{
    public interface ICanvas
    {
        
        void DrawLine(Point point1, Point point2);
        void DrawRect(Point point1, Point point2);
        void DrawRound(Point point, double radius);
    }
}
