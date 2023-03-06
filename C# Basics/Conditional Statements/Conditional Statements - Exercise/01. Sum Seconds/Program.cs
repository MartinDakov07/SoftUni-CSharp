using System;

namespace Conditional_Statements___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstRunner = int.Parse(Console.ReadLine());
            int secondRunner = int.Parse(Console.ReadLine());
            int thirdRunner = int.Parse(Console.ReadLine());
            int timeForAllRunners = firstRunner + secondRunner + thirdRunner;
            int min = timeForAllRunners / 60;
            int sec = timeForAllRunners % 60;
            if (sec <10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
