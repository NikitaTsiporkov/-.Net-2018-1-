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
            string uniqueSecond = new string (second.Distinct().ToArray());
            Console.WriteLine("Result: " + AddDublicates(first, uniqueSecond));
            Console.ReadKey();
        }
        static string AddDublicates(string input, string dublicate)    //Попробовать через метод 
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
