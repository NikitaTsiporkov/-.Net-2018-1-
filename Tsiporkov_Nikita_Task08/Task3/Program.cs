using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "THIS this ThiS is IS iS text with multile words, that we are gonna count!";
            string[] stringArr = DeleteSpacesAndPunctuation(str);
            var numberOfWords = stringArr.Length;
            var uniqueStr = stringArr.Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
            int[] numberOfIntromission = new int[uniqueStr.Length];
            List<KeyValuePair<string, double>> WordAndNumber = new List<KeyValuePair<string, double>>();
            FindingWords(uniqueStr, numberOfIntromission, str, WordAndNumber, numberOfWords);
            Console.WriteLine(str);
            Console.WriteLine("Word : Rate");
            WordAndNumber.Sort(new ValueComparer<string, double>());
            Writeline(WordAndNumber, WordAndNumber.Count);
            Console.ReadKey();
        }

        static string[] DeleteSpacesAndPunctuation(string s)
        {
            Regex rgx = new Regex("\\W");
            string[] wordsOnly = rgx.Split(s).Where(str => str != String.Empty).ToArray();
            return wordsOnly;
        }

        private static void FindingWords(string[] words, int[] count, string source, List<KeyValuePair<string, double>> list, int numberOfWords)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string pattern = "\\b(?i)" + words[i] + "(?-i)\\b";
                count[i] = new Regex(pattern).Matches(source).Count;
                double rate = count[i]/(numberOfWords*0.01);
                list.Add(new KeyValuePair<string, double>(words[i], rate));
            }
        }
        private static void Writeline(List<KeyValuePair<string, double>> list, int NumOfIteration)
        {
            for (int i = 0; i < NumOfIteration; i++)
            {
                Console.WriteLine("{0} : {1:0.##}%", list[i].Key, list[i].Value);
            }
        }
        public class ValueComparer<TKey, TValue> : IComparer<KeyValuePair<TKey, TValue>> where TValue : IComparable
        {
            public int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
            {
                return y.Value.CompareTo(x.Value);
            }
        }
    }
}