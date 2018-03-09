using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round();
            round.X = 1;
            round.Y = 4;
            round.Radius = 5;
            Console.WriteLine("Length: " + round.Length + " Square: " + round.Square);
            Console.ReadKey();
        }
    }
}
