using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LibraryClass;
using System.Drawing;

namespace Task1
{
    public class ConsoleCanvas : ICanvas
    {
        public void DrawLine(Point point1, Point point2)
        {
            Console.WriteLine($"Рисуем линию ({point1.X}, {point1.Y}) ({point2.X}, {point2.Y})");
        }

        public void DrawRect(Point point1, Point point2)
        {
            Console.WriteLine($"Рисуем прямоугольник ({point1.X}, {point1.Y}), ({point2.X}, {point2.Y})");
        }

        public void DrawRound(Point point1, double radius, double innerRadius)
        {
            if (innerRadius == 0)
            {
                Console.WriteLine($"Рисуем круг в ({point1.X}, {point1.Y}) с радиусом {radius}");
            }
            else
            {
                Console.WriteLine($"Рисуем кольцо в ({point1.X}, {point1.Y}) с радиусом {radius} и внутренним {innerRadius}");
            }
        }
    }
}