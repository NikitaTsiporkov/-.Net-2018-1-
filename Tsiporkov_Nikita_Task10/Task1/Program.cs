using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ClassLibrary1.Class1.Factorial(4));
            //Console.WriteLine(ClassLibrary1.Class1.PowerOfNumber(2,5));
            int x = 5;
            int y = 7;
            Console.WriteLine(Hash(x) + Hash(y));
            Console.ReadKey();
        }

        static int Hash(int x)
        {
            int hash = 0;
            for (int i = 0; i < 32; i++)
            {
                int b = (int)Math.Pow(2, i);
                if (x >= 0)
                {
                    if ((x & b) == 1)
                    {
                        hash += b;
                    }
                }
                else
                {
                    b = -b;
                    if ((x & b) == 1)
                    {
                        hash += b;
                    }
                }
            }
            return hash;
        }
    }
}
