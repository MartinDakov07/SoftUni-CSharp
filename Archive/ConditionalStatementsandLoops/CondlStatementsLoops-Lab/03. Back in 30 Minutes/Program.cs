using System;

namespace _03._Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;
            if(minutes > 59)
            {
                minutes = minutes - 60;
                hours++;
            }
            if(hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
