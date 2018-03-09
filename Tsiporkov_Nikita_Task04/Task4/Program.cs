using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString a = new MyString("Hello");
            MyString b = new MyString("ll");
            MyString c = new MyString();
            Console.WriteLine("ToString method: " + a.ToString());
            c = a + b;
            MyString d = new MyString();
            d = a - b;
            if (a == b)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки равны");
            }
            Console.WriteLine(c.Text);
            Console.WriteLine(d.Text);
            Console.ReadKey();
        }
    }
}
