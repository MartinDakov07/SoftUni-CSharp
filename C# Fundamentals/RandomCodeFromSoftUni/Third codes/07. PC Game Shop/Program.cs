using System;

namespace _07._PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOfGames = double.Parse(Console.ReadLine());
            double fortniteCount = 0;
            double hearthstoneCount = 0;
            double overwatchCount = 0;
            double otherCount = 0;
            
            for(int i = 0; i < numOfGames; i++)
            {
                string gameName = Console.ReadLine();
                if(gameName == "Fornite")
                {
                  fortniteCount++;
                }
                else if(gameName == "Hearthstone")
                {
                    hearthstoneCount++;
                }
                else if(gameName == "Overwatch")
                {
                    overwatchCount++;
                }
                else
                {
                    otherCount++;
                }
            }
            Console.WriteLine($"Hearthstone - {((hearthstoneCount/numOfGames)*100):f2}%");
            Console.WriteLine($"Fornite - {((fortniteCount / numOfGames) * 100):f2}%");
            Console.WriteLine($"Overwatch - {((overwatchCount / numOfGames) * 100):f2}%");
            Console.WriteLine($"Others - {((otherCount / numOfGames) * 100):f2}%");
        }
    }
}
