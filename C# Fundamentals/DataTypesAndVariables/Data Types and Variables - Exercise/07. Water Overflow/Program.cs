using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int pours = int.Parse(Console.ReadLine());
            int totalLiters = 0;
            for(int i = 0; i < pours; i++)
            {
                int liters = int.Parse(Console.ReadLine());
               
                if(liters >= tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    liters = 0;
                }
                totalLiters += liters;
                tankCapacity -= liters;

            }
            Console.WriteLine($"{totalLiters}");





        }
    }
}
