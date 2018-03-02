using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
            Console.Write("2 Dimension: ");
            int p = int.Parse(Console.ReadLine());
            int[,,] array = new int[n, m, p];
            FillArray(array);
            array = FillPositiveWithZero(array);
            Console.ReadKey();
        }
        static int[,,] FillArray(int[,,] array)
        {
            for (int z = 0; z < array.GetLength(0); z++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int i = 0; i < array.GetLength(2); i++)
                    {
                        array[z, j, i] = rnd.Next(-100, 100);
                    }
            return array;
        }
        static int[,,] FillPositiveWithZero(int[,,] array)
        {
            for (int z = 0; z < array.GetLength(0); z++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int i = 0; i < array.GetLength(2); i++)
                    {
                        if (array[z, j, i] > 0)
                        {
                            array[z, j, i] = 0;
                        }
                    }
            return array;
        }
    }
}
