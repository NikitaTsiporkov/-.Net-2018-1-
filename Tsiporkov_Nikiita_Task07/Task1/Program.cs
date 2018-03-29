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
            DynamicArray<int> array = new DynamicArray<int>();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(6);
            Write(array);
            int[] arr = new int[]{ 1,2,3};
            Console.WriteLine("Add Range:");
            array.AddRange(arr);
            Write(array);
            Console.WriteLine("Insert: ");
            array.Insert(9, 5);
            Write(array);
            Console.WriteLine("Add: ");
            array.Add(8);
            Write(array);
            Console.WriteLine("Remove: ");
            array.Remove(1);
            Write(array);
            Console.WriteLine("Sort: ");
            array.Sort();
            Write(array);
            Console.WriteLine("Foreach: ");
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
        public static void Write(DynamicArray<int> IT)
        {
            for (int i = 0; i < IT.Length; i++)
            {
                Console.WriteLine(i + " : " + IT[i]);
            }
            Console.WriteLine($"Capacity : {IT.Capacity}   Length : {IT.Length}");
        }
    }
}
