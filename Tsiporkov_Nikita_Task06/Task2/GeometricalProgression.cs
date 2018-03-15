using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task2
{
    public class GeometricalProgression : ISeries
    {
            double step;
            int currentIndex;
            double current;

            public GeometricalProgression(double start, double step)
            {
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
    }
}