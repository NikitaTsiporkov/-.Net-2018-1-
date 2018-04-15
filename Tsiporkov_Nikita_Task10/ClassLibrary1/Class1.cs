using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Class1
    {
        public static double PowerOfNumber(double number, double power)
        {
            return Math.Pow(number, power);
        }

        public static int Factorial(int number)
        {
            int temp=1;
            if (number < 0)
            {
                throw new ArgumentException("Number must be positive");
            }
            for(int i=1;i<=number;i++)
            {
                temp *= i;
            }
            return temp;
        }

        public static int GetNumber(DateTime date, int temp = 0)
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
