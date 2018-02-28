using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static private void Tree(int line,int tree)
        {
            int numberofwhitespace = tree - 1;
            int numberofstars = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < line; i++)
            {
                string whitespaces = new string(' ', numberofwhitespace);
                numberofwhitespace--;
                string stars = new string('*', numberofstars);
                numberofstars = numberofstars + 2;
                Console.WriteLine(whitespaces + stars);
            }
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number of tree = ");
            string input = Console.ReadLine();
            int numberoftree = int.Parse(input);
            int line = 0;
            for (int i = 0; i < numberoftree; i++)
            {
                line++;
                Tree(line, numberoftree);
            }
            Console.ReadKey();
        }
    }
}
