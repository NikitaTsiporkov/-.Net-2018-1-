using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            int count = Regex.Matches(input, "([0-1][0-9]:[0-5][0-9])|([2][0-3]:[0-5][0-9])|(\\b[0-9]:[0-5][0-9]\\b)").Count;
            Console.WriteLine("Time meet: {0}", count);
            Console.ReadKey();
        }
    }
}
