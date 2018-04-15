using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Watcher watcher = new Watcher(@"D:\Epam\-.Net-2018-1-\Tsiporkov_Nikita_Task11\Monitoring folder");
            Console.WriteLine("To turn on the Watcher? [y/n]");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Y)
            {
                watcher.On = true;
                Console.WriteLine();
                Console.WriteLine("Watcher is on!");
                Console.WriteLine("Please enter [r] if you want to rollback.");
                Console.WriteLine("If you want go out, enter [q].");
                do
                {
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.R)
                    {
                        foreach (var i in watcher.three)
                        {
                            Console.WriteLine("|" + i.Key + "|" + i.Value);
                        }
                        Console.WriteLine("Enter number of version:");
                        Int32.TryParse(Console.ReadLine(), out int version);
                        watcher.RollBack(version);
                        Console.WriteLine("If you want go out, enter [q].");
                    }
                } while (cki.Key != ConsoleKey.Q);
            }
            else if (cki.Key == ConsoleKey.N)
            {
                Console.WriteLine();
                Console.WriteLine("If you want go out, enter [q].");
                do
                {
                    cki = Console.ReadKey();
                }
                while (cki.Key != ConsoleKey.Q);
            }
            else
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("If you want go out, enter [q].");
                    cki = Console.ReadKey();
                }
                while (cki.Key != ConsoleKey.Q) ;
            }
        }
    }
}
