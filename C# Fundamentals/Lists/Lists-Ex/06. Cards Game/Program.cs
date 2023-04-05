using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            while(firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                
                int firstCard = firstPlayer[0];
                int secondCard = secondPlayer[0];
                if(firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                    firstPlayer.Add(secondCard);
                    firstPlayer.Add(firstCard);
                    
                    
                   
                }
                else if(secondPlayer[0] > firstPlayer[0])
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                    secondPlayer.Add(firstCard);
                    secondPlayer.Add(secondCard);
                    
                    
                }
                else if(firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                }
                
            }
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i < firstPlayer.Count; i++)
            {
                sum1 += firstPlayer[i];
            }
            for(int j = 0; j < secondPlayer.Count; j++)
            {
                sum2 += secondPlayer[j];
            }
            if(sum1 > sum2)
            {
                Console.WriteLine($"First player wins! Sum: {sum1}");
            }
            else if(sum2 > sum1)
            {
                Console.WriteLine($"Second player wins! Sum: {sum2}");
            }
        }
    }
}
