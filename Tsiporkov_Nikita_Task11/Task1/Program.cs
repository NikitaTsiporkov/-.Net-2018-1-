using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "D:\\Epam\\-.Net-2018-1-\\disposable_task_file1.txt";
                string[] textOfFile;
                using (StreamReader reader = new StreamReader(path))
                {
                    var list = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        list.Add(line);
                    }
                    textOfFile = list.ToArray();
                }
                PowerNumber(textOfFile);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var a in textOfFile)
                    {
                        sw.WriteLine(a);
                    }
                }
                Console.WriteLine("File succsesfully rewrite");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        static void PowerNumber(string[] input)
        {
            Regex rgx = new Regex("\\b[0-9]+[,.]?[0-9]*\\b");
            for (int i = 0; i < input.Length; i++)
            {
                int j = 0;
                while (rgx.IsMatch(input[i], j))
                {
                    Match m = rgx.Match(input[i], j);
                    double mNew = Math.Pow(double.Parse(m.ToString()), 2);
                    input[i] = input[i].Replace(m.ToString(), mNew.ToString());
                    j = m.Index + mNew.ToString().Length;
                }
            }
        }
    }
}
