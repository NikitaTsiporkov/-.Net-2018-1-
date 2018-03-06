using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex science = new Regex("\\b[0-9,.]+e[0-9-]+\\b");
            Regex regular = new Regex("\\b[0-9.,]+\\b");
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (science.IsMatch(input))
            {
                Console.WriteLine("This number is in science notation");
            }
            else
            {
                if (regular.IsMatch(input))
                {
                    Console.WriteLine("This number is in regular notation");
                }
                else
                {
                    Console.WriteLine("This is not number");
                }
            }
            Console.ReadKey();
        }
    }
}
