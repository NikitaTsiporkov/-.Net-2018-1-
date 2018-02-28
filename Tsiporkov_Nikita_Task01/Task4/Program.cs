using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N = ");
            string input = Console.ReadLine();
            int line = int.Parse(input);
            int numberofwhitespace = line - 1;
            int numberofstars = 1;
            for (int i = 0; i < line; i++)
            {
                string whitespaces = new string(' ', numberofwhitespace);
                numberofwhitespace--;
                string stars = new string('*', numberofstars);
                numberofstars = numberofstars + 2;
                Console.WriteLine(whitespaces + stars);
            }
            Console.ReadKey();
        }
    }
}
