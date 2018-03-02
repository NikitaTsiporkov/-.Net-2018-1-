using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            FillArray(array);
            Display(array);
            Console.WriteLine("Sum: " + SumOfPositive(array));
            Console.ReadKey();
        }
        static void Display(int[] array)
        {
            Console.WriteLine(string.Join(",", array));
        }
        static int[] FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }
        static int SumOfPositive(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum = sum + array[i];
                }
            }
            return sum;
        }
    }
}
