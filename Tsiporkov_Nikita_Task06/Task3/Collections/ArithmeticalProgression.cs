using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Interfaces;

namespace Task3.Collections
{
    public class ArithmeticalProgression : IIndexableSeries
    {
        double start, step;
        int currentIndex;
        double current;

        public ArithmeticalProgression(double start, double step)
        {
            this.start = start;
            current = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return current;
        }

        public bool MoveNext()
        {
            current += step;
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }

        public double this[int index]
        {
            get
            {
                return start + step * (index-1);
            }
        }
    }
}
