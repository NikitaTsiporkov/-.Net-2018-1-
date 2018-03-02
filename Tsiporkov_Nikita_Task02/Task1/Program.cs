using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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
            Sort(array);
            Display(array);
            Console.WriteLine("Minimum :" + GetMin(array));
            Console.WriteLine("Maximum :" + GetMax(array));
            Console.ReadKey();
        }
        static int[] FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }
            return array;
        }
        static int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int GetMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int[] Sort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            return array;
        }
        static void Display(int[] array)
        {
            Console.WriteLine(string.Join(",", array));
        }
    }
}