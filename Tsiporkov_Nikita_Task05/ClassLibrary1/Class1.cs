using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Class1
    {
        public static int GetNumber(DateTime date, int temp=0)
        {
            if (DateTime.Today.Month < date.Month)
            {
                temp = DateTime.Today.Year - date.Year - 1;
            }
            else
            {
                temp = DateTime.Today.Year - date.Year;
            }
            return temp;
        }
    }
}
