using System;
using Task3.Interfaces;

namespace Task3
{
    public class GeometricalProgression : IIndexableSeries
    {
        double start,step;
        int currentIndex;
        double current;

        public GeometricalProgression(double start, double step)
        {
            this.start = start;
            current = start;
            this.step = step;
            currentIndex = 1;

        }

        public double GetCurrent()
        {
            return current;
        }

        public bool MoveNext()
        {
            current *= step;
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
                return start * Math.Pow(step,index-1);
            }
        }
    }
}