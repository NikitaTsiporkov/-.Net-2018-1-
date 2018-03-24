using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Interfaces;

namespace Task3.Collections
{
    public class List : IIndexableSeries
    {
        private double[] series;
        private int currentIndex;

        public List(double[] series)
        {
            this.series = series;
            currentIndex = 0;
        }

        public double GetCurrent()
        {
            return series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex++;
            return (currentIndex <= series.Length - 1);
            
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < series.Length)
                {
                    return series[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }
    }
}
