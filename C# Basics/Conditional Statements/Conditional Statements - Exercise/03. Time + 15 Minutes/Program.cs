using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min = min + hours * 60; //prevryshtame chasovete v minuti
            int futureMin = min + 15;// min = 60 60+15 = 75
            int hoursAfter = futureMin / 60;
            int minAfter = futureMin % 60;
            if (hoursAfter >23)
            {
                hoursAfter = 0;
            }
            if (minAfter < 10)
            {
                Console.WriteLine($"{hoursAfter}:0{minAfter}");
            }
            else
            {
                Console.WriteLine($"{hoursAfter}:{minAfter}");
            }
        }
    }
}
