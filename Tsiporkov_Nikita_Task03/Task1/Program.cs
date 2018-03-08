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
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Average number of chars in word: " + AverageChars(str));
            Console.ReadKey();
        }
        static int AverageChars(string s)
        {
            char[] punctuation = new char[s.Length];
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsPunctuation(s[i]))
                {
                    punctuation[j] = s[i];
                    j++;
                }
            }
            string[] substr = s.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
            int numberOfWords = substr.Length;
            int sumOfChars = 0;
            for (int i = 0; i < substr.Length; i++)
            {
                sumOfChars += substr[i].Length;
            }
            int avg = sumOfChars / numberOfWords;
            return avg;
        }
    }
}
