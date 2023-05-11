using System;

namespace _06._Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int totalSize = height * width * 4;
            double percent = double.Parse(Console.ReadLine()) / 100;
            double wallPaint =Math.Ceiling (totalSize - totalSize * percent);
            string paint = Console.ReadLine();
            int paintUsed = 0;
            while(paint != "Tired!")
            {
                paintUsed = 0;
                paintUsed = int.Parse(paint);
                wallPaint -= paintUsed;
                if(wallPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(wallPaint)} l paint left!");
                    break;
                }
                if (wallPaint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }


                paint = Console.ReadLine();
            }
            if(paint == "Tired!")
            {
                Console.WriteLine($"{wallPaint} quadratic m left.");
          
            }
            
           


        }
    }
}
