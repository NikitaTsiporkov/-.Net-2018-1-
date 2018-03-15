using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Collections;
using Task3.Interfaces;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IIndexableSeries arProgression = new ArithmeticalProgression(2, 2);
            Console.Write("Arithmetical Progression: ");
            PrintSeries(arProgression);
            Console.WriteLine();
            Console.WriteLine(arProgression[2]);

            IIndexableSeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.Write("List: ");
            PrintSeries(list);
            Console.WriteLine();
            Console.WriteLine(list[2]);

            IIndexableSeries geoProgression = new GeometricalProgression(2, 2);
            Console.Write("Geometrical Progression: ");
            PrintSeries(geoProgression);
            Console.WriteLine();
            Console.WriteLine(geoProgression[2]);

            Console.ReadKey();
        }
        static void PrintSeries(IIndexableSeries indexSeries)
        {
            indexSeries.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(indexSeries.GetCurrent() + " ");
                indexSeries.MoveNext();
            }
        }
    }
}
