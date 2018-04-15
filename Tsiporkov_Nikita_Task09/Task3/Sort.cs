using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task3
{
    class Sort
    {

        public string Name { get; set; }
        public string[] ArrayString { get; set; }

        public void SortArray(Comparision del)
        {
            string temp;
            for (int i = 0; i < ArrayString.Length; i++)
            {
                for (int j = i + 1; j < ArrayString.Length; j++)
                {
                    if (del(ArrayString[i], ArrayString[j]))
                    {
                        temp = ArrayString[i];
                        ArrayString[i] = ArrayString[j];
                        ArrayString[j] = temp;
                    }
                }
            }
        }

        public void Sorting(Comparision del)
        {
            SortArray(del);
            IsFinish();
        }
        public delegate void PrintArray(Sort sender); 
        public event PrintArray SortFinish1;

        public void IsFinish()
        {
            SortFinish1?.Invoke(this);
        }
    }
}
