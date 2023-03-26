using System;

namespace P01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] daysOfWeek = new string[7]
            {

                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                 "Friday",
                 "Saturday",
                 "Sunday"
            };
            int day = int.Parse(Console.ReadLine());
            if(day > 7 || day < 1)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(daysOfWeek[day-1]);

        }
    }
}
