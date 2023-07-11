using System;

namespace _11._Convert_Speed_Units
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;            
            float speedInMeters = distance / totalTimeInSeconds;
            float speedInKilometers = (distance / 1000) / (totalTimeInSeconds / 3600);            
            float milesPerHours = (distance / 1609) / (totalTimeInSeconds / 3600);
            Console.WriteLine($"{speedInMeters:f7}");
            Console.WriteLine($"{speedInKilometers:f7}");
            Console.WriteLine($"{milesPerHours:f7}");
        }
    }
}
