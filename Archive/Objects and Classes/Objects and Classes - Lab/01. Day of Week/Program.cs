using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime week = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            //int[] dateArg = date.Split('-').Select(int.Parse).ToArray();
            //new DateTime(year: dateArg[2], month: dateArg[1], day: dateArg[0]);
            Console.WriteLine(week.DayOfWeek);
        }
    }
}
