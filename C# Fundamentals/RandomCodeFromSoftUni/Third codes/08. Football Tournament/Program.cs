using System;

namespace _08._Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            double matches = double.Parse(Console.ReadLine());
            char result;
            int winCount = 0;
            int drawCount = 0;
            int loseCount = 0;
            double points = 0;
            for(int i = 0; i < matches; i++)
            {
                result = char.Parse(Console.ReadLine());
                if(result == 'W')
                {
                    winCount++;
                    points += 3;
                }
                else if(result == 'D')
                {
                    drawCount++;
                    points++;
                }
                else if(result == 'L')
                {
                    loseCount++;                  
                }
            }
            if(matches <= 0)
            {
                Console.WriteLine($"{footballTeam} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{footballTeam} has won {points} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {winCount}");
                Console.WriteLine($"## D: {drawCount}" );
                Console.WriteLine($"## L: {loseCount}" );
                Console.WriteLine($"Win rate: {((winCount/matches)*100):f2}%");
            }
        }
    }
}
