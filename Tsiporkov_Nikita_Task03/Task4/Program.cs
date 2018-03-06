using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            string str = "";
            StringBuilder sb = new StringBuilder();
            int n = 100;
            string adder = "*";
            stopWatch.Start();
            for (int i = 0; i < n; i++)
            {
                str += adder;
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"Time elapsed to sum {n} strings: {ts}");
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < n; i++)
            {
                sb.Append(adder);
            }
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;
            Console.WriteLine($"Time elapsed to append {n} stringbuilder: {ts2}");
            Console.ReadKey();
        }
    }
}
