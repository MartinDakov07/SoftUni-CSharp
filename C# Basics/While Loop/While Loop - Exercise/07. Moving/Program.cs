using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = widht * lenght * height;
            int boxes = 0;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                boxes = int.Parse(input);
                if (freeSpace >= boxes)
                {
                    freeSpace -= boxes;
                }
                else
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace - boxes)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine(); 
                
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
