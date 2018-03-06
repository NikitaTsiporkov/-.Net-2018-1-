using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text with html tags: ");
            string input = Console.ReadLine();
            string pattern = "<[^>]+>";
            string replacement = "_";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            Console.WriteLine("String without html tags: " + result);
            Console.ReadKey();
        }
    }
}
