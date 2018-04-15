using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User Peter = new User("Peter", "Gabrazhanovskiy", new DateTime(1997,12,5));
            User user = null;
            User Peter1 = new User("Peter", "Gabrazhanovskiy", new DateTime(1997, 12, 5));
            Console.WriteLine(Peter.Equals(user));
            Console.ReadKey();
        }
    }
}
