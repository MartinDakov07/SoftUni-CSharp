using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            for (int currFloors = floor; currFloors >= 1; currFloors--)
            {
                for(int curRoom = 0; curRoom < room; curRoom++)
                {
                    if(currFloors == floor)
                    {
                        Console.Write($"L{currFloors}{curRoom} ");
                    }
                    else if(currFloors % 2 == 0)
                    {
                        Console.Write($"O{currFloors}{curRoom} ");
                    }
                    else 
                    {
                        Console.Write($"A{currFloors}{curRoom} ");
                    }
                }
                Console.WriteLine();
                
            }
        }
    }
}
