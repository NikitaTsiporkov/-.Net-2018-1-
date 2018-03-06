using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static DateTime localDate = DateTime.Now;
        static void Main(string[] args)
        {
            Console.Write("Enter name of culture: ");
            string firstCulture = Console.ReadLine();
            Console.Write("Enter name of comparing culture: ");
            string secondCulture = Console.ReadLine();
            DisplayTable(firstCulture, secondCulture);
            Console.ReadKey();
        }
        static string DateOfCulture(string cultureName)
        {
            var culture = new CultureInfo(cultureName);
            string data = localDate.ToString(culture);
            return data;
        }
        static void DisplayTable(string firstname, string secondname)
        {
            try
            {
                var culture1 = new CultureInfo(firstname);
                var culture2 = new CultureInfo(secondname);
                Console.WriteLine("Name\t\t\t{0}\t\t\t{1}", culture1.Name, culture2.Name);
                Console.WriteLine("Data\t\t\t{0}\t{1}", DateOfCulture(firstname), DateOfCulture(secondname));
                Console.WriteLine("DateSeparator\t\t{0}\t\t\t{1}", culture1.DateTimeFormat.DateSeparator, culture2.DateTimeFormat.DateSeparator);
                Console.WriteLine("CurrencySymbol\t\t{0}\t\t\t{1}", culture1.NumberFormat.CurrencySymbol, culture2.NumberFormat.CurrencySymbol);
                Console.WriteLine("DecimalSeparator\t{0}\t\t\t{1}", culture1.NumberFormat.NumberDecimalSeparator, culture1.NumberFormat.NumberDecimalSeparator);
                Console.WriteLine("GroupSeparator\t\t{0}\t\t\t{1}", culture1.NumberFormat.NumberGroupSeparator, culture1.NumberFormat.NumberGroupSeparator);
            }
            catch (Exception) { Console.WriteLine("Entered unknown culture"); }
        }
    }
}
