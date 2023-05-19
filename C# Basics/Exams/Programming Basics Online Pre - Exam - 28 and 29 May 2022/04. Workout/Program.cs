using System;

namespace _04._Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometersForFirstDay = int.Parse(Console.ReadLine());
            int percentPerDay = int.Parse(Console.ReadLine());
            double totalKilometers = kilometersForFirstDay + (kilometersForFirstDay * percentPerDay)/100;
            double totalSuperKilometers = kilometersForFirstDay + totalKilometers;
            for(int i = 2; i <= days; i++)
            {
                 percentPerDay = int.Parse(Console.ReadLine());

                totalKilometers = totalKilometers + (totalKilometers * percentPerDay) / 100;
                totalSuperKilometers += totalKilometers;
            }

            if (totalSuperKilometers >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(Math.Abs(1000 - totalSuperKilometers))} more kilometers!");

            }
            else if(totalSuperKilometers < 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(Math.Abs(1000 - totalSuperKilometers))} more kilometers");

            }
        }
    }
}
