using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int filmTime = int.Parse(Console.ReadLine());
            int seriesBreak = int.Parse(Console.ReadLine());
            double timeForSeries = seriesBreak * 5 / 8.0;
            double difference = timeForSeries - filmTime;
            if (timeForSeries >= filmTime)
            {
                Console.WriteLine($"You have enough time to watch {film} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {film}, you need {Math.Ceiling(filmTime - timeForSeries)} more minutes.");
            }
        }
    }
}
