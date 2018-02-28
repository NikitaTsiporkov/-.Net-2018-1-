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
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            int sum1 = 0;
            for (int i = 0; i < 1000; i += 3)
            {
                sum1 += i;
            }
            for (int i = 0; i < 1000; i += 5)
            {
                if(!(i%3==0))
                sum1 += i;
            }
            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Sum of numbers1: " + sum1);
            Console.ReadKey();
        }
    }
}
