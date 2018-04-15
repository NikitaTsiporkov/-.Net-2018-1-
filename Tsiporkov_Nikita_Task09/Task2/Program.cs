using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        delegate void Message(Person name, int hour);

        static void Main(string[] args)
        {
            Person john = new Person { Name = "Джон" };
            Person mary = new Person { Name = "Мэри" };
            Person hugo = new Person { Name = "Хьюго" };
            Person bill = new Person { Name = "Билл" };

            Office office = new Office();
            office.AddWorker(john, 8);
            office.AddWorker(hugo, 11);
            office.AddWorker(mary, 15);
            office.AddWorker(bill, 18);
            office.RemoveWorker(john);
            office.AddWorker(new Person { Name = "Костя" }, 19);
            office.RemoveWorker(mary);
            office.RemoveWorker(hugo);
            office.RemoveWorker(bill);
            Console.ReadKey();
        }
    }
}
