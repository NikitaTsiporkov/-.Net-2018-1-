using System;
using System.Threading;

namespace Task3
{
    delegate bool Comparision(string a, string b);

    class Program
    {
        static void Main(string[] args)
        {
            Sort array1 = new Sort
            {
                Name = "Array 1",
                ArrayString = new string[3] { "abcd", "bbc", "ads" }
            };

            Sort array2 = new Sort
            {
                Name = "Array 2",
                ArrayString = new string[3] { "abcd", "bbc", "ads" }
            };

            Comparision comp = new Comparision(StringCompare);
            array1.SortFinish1 += Print;
            array2.SortFinish1 += Print;

            ThreadStart sort1 = () =>
            {
                array1.Sorting(comp);
            };
            Thread thread1 = new Thread(sort1);

            ThreadStart sort2 = () =>
            {
                array2.Sorting(comp);
            };
            Thread thread2 = new Thread(sort2);

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }
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

        static void Print(Sort sender)
        {
            Console.WriteLine("Sort is finished");
            for (int i = 0; i < sender.ArrayString.Length; i++)
            {
                Console.WriteLine($"{sender.Name} - {sender.ArrayString[i]}");
            }
            Thread.Sleep(100);
        }
    }
}
