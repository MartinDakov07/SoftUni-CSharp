using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numKegs = int.Parse(Console.ReadLine());
            string model = string.Empty;
            double radius = 0;
            int height = 0;
            double topVolume = 0;
            string topModel = string.Empty;
            for(int i = 0;i < numKegs; i++)
            {
                radius = 0;
                height = 0;
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                double volume = (double)(Math.PI * (radius * radius) * height);
                if(volume > topVolume)
                {
                    topVolume = volume;
                    topModel = model;
                }

            }
            Console.WriteLine($"{topModel}");
            
        }
    }
}
