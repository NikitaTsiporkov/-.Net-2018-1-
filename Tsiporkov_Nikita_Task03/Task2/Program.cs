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
            Console.Write("Enter first string: ");
            string first = Console.ReadLine();
            Console.Write("Enter second string: ");
            string second = Console.ReadLine();
            string uniqueSecond = RemoveDupes(second);
            Console.WriteLine("Result: " + AddDublicates(first, uniqueSecond));
            Console.ReadKey();
        }
        static string RemoveDupes(string s)
        {
            string newString = string.Empty;
            List<char> found = new List<char>();
            foreach (char c in s)
            {
                if (found.Contains(c))
                {
                    continue;
                }
                newString += c.ToString();
                found.Add(c);
            }
            return newString;
        }
        static string AddDublicates(string input, string dublicate)
        {
            for (int j = 0; j < dublicate.Length; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == dublicate[j])
                    {
                        input = input.Insert(i, dublicate[j].ToString());
                        i++;
                    }
                }
            }
            return input;
        }
    }
}
