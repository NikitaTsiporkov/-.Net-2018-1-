using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            Console.Write("0 Dimension: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("1 Dimension: ");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            FillArray(array);
            Display(array);
            Console.WriteLine("Sum: " + SumOfpositivenumbers(array));
            Console.ReadKey();
        }
        static int[,] FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(100);
                }
            return array;
        }
        static void Display(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int SumOfpositivenumbers(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum = sum + array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}