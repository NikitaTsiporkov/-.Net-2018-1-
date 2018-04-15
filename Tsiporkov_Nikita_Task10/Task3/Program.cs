using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hashCodes = new List<int>();
            List<int> Xs = new List<int>();
            List<int> Ys = new List<int>();
            int range = 1000;
            for (int i = 0; i < range; i++)
            {
                for (int j = 0; j < range; j++)
                {
                    TwoDPointWithHash point = new TwoDPointWithHash(i, j);
                    hashCodes.Add(point.GetHashCode());
                }
            }
            for (int i = -1; i > -range; i--)
            {
                for (int j = 0; j > -range; j--)
                {
                    TwoDPointWithHash point = new TwoDPointWithHash(i, j);
                    hashCodes.Add(point.GetHashCode());
                }
            }
            List<int> unique = hashCodes.Distinct().ToList();
            List<int> sam1 = new List<int>();
            HashSet<int> hash = new HashSet<int>();
            foreach (int number in hashCodes)
                if (!hash.Add(number))
                {
                    sam1.Add(number);
                }
            Console.WriteLine($"All count = {hashCodes.Count}");
            Console.WriteLine($"Unique count = {unique.Count}");
            Console.WriteLine($"The same count = {hashCodes.Count - unique.Count}");
            double countOfSame = (double)(hashCodes.Count - unique.Count) * 100 / hashCodes.Count;
            Console.WriteLine($"Percent = {countOfSame}");
            Console.ReadKey();
        }
    }
}
