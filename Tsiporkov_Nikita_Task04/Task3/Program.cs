using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.A = 3;
            triangle.B = 4;
            triangle.C = 5;
            Console.WriteLine("Perimetr: " + triangle.Perimetr() + " Square: " + triangle.Square());
            Console.ReadKey();
        }
    }
}
