using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTurnirs = int.Parse(Console.ReadLine());
            int currentPoints = int.Parse(Console.ReadLine()); ;
            string rank = string.Empty;
            int currentSum = 0;
            int rankW = 0;
            
            
            for (int i = 0; i < numTurnirs; i++)
            {
                rank = Console.ReadLine();
                
                if (rank == "W")
                {
                    currentSum += 2000;
                    rankW++;
                }
                else if (rank == "F")
                {
                    currentSum += 1200;
                    
                }
                else if (rank == "SF")
                {
                    currentSum += 720;
                    
                }
                
            }
            double totalPoints = currentSum + currentPoints;
            double averageScore = currentSum / numTurnirs;
            
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averageScore)}");
            Console.WriteLine($"{(100.0 * rankW / numTurnirs):f2}%");
           
            
        }
    }
}
