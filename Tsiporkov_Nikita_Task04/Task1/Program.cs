using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date of birthday of user: ");
            string userName =Console.ReadLine();
            DateTime date = new DateTime(05/12/1997);
            User user = new User("Никита","Ципорков", date);
            Console.WriteLine(user.DateOfBirth);
            Console.WriteLine("Age: " + user.Age);
            Console.ReadKey();
        }
    }
}
