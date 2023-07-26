using System;
using System.Globalization;

namespace _10._Holidays_Between_Two_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);//if its dd and we take 1-9, it will write us with 0 in front
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);// plus M is for month, and mm is for minutes
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))//date = date.AddDays(1) because it wont make anything
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;// || instead of &&

            Console.WriteLine(holidaysCount);

        }
    }
}
