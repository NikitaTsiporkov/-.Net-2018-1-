using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            FillCollection(list, 15);
            var listName = new List<string>() {"John1", "John2", "John3", "John4", "John5", "John6", "John7", "John8"
            ,"John9", "John10", "John11", "John12", "John13", "John14", "John15"};
            RemoveEachSecond(list);
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
        static void FillCollection(ICollection<int> collection, int length)
        {
            length++;
            for (int i = 1; i < length; i++)
            {
                collection.Add(i);
            }
        }

        static void RemoveEachSecond<T>(ICollection<T> collection)
        {
            bool IsEven = false;
            while (collection.Count != 1)
            {
               var evenElements = new List<T>();

                foreach (var item in collection)
                {
                    if (IsEven)
                    {
                        evenElements.Add(item);
                    }
                    IsEven = !IsEven;
                }
                foreach (var item in evenElements)
                {
                    collection.Remove(item);
                }
            }
        }
    }
}