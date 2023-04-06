using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> timeOfBothRacers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> firstPlayer = new List<int>();
            List<int> secondPlayer = new List<int>();

            int middle = timeOfBothRacers.Count / 2;
           for(int i = 0; i < middle; i++)
           {
                firstPlayer.Add(timeOfBothRacers[i]);
           }
            for(int i = 1; i <= middle; i++)
            {               
                secondPlayer.Add(timeOfBothRacers[timeOfBothRacers.Count - i]);
            }
            double firstPlayerTotalTime = 0;
            double secondPlayerTotalTime = 0;   
            foreach(int time in firstPlayer)
            {
                if(time == 0)
                {
                    firstPlayerTotalTime *= 0.8;
                    continue;
                }
                firstPlayerTotalTime += time;
            }
            foreach(int time in secondPlayer)
            {
                if(time == 0)
                {
                    secondPlayerTotalTime *= 0.8;
                    continue;
                }
                secondPlayerTotalTime += time;
            }
            if(secondPlayerTotalTime < firstPlayerTotalTime)
            {                                
                Console.WriteLine($"The winner is right with total time: {secondPlayerTotalTime}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {firstPlayerTotalTime}");
            }
        }
    }
}
