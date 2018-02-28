using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a:");
            string input = Console.ReadLine();
            int a = int.Parse(input);
            Console.WriteLine("Input b:");
            string input1 = Console.ReadLine();
            int b = int.Parse(input1);
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                int s = a * b;
                Console.WriteLine("Squre of triangle: " + S);
            }
            Console.ReadKey();
        }
    }
}
