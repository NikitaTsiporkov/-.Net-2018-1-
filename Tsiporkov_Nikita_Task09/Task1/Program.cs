using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate bool Comparision(string a, string b);

        static bool StringCompare(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return (a.Length > b.Length);
            }
            else
            {
                return (string.Compare(a, b) == 1);
            }
        }

        static void Main(string[] args)
        {
            string[] mas = new string[] { "abcd","bbc","ads" };
            Comparision del = StringCompare;
            Sort(mas, del);
        }

        static string[] Sort(string[] input, Comparision del)
        {
            string temp;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (del(input[i],input[j]))
                    {
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
    }
}
