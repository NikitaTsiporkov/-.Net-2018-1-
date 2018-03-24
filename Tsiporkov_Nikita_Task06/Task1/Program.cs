using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LibraryClass;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure[] figure = new IFigure[4];
            figure[0] = new Line(RandomPoint(), RandomPoint());
            figure[1] = new Rect(RandomPoint(), RandomPoint());
            figure[2] = new Round(RandomPoint(), 3);
            figure[3] = new Ring(RandomPoint(), 7, 5);
            ICanvas console = new ConsoleCanvas();
            for (int i = 0; i < figure.Length; i++)
            {
                Console.WriteLine(figure[i].Name);
                figure[i].Draw(console);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static Point RandomPoint()
        {
            Point point = new Point();
            point.X = rnd.Next(-10, 10);
            point.Y = rnd.Next(-10, 10);
            return point;
        }
        static Random rnd = new Random();

    }
}
