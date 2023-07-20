using System;

namespace _14._Boat_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int firstBoatTiles = 0;
            int secondBoatTiles = 0;
            for(int i = 1; i <= n; i++)
            {
                string tiles = Console.ReadLine();
                if (tiles == "UPGRADE")
                {
                    firstBoat = (char)((int)firstBoat + 3);
                    secondBoat = (char)((int)secondBoat + 3);
                    continue;
                }
                if (i % 2 != 0) 
                {
                    firstBoatTiles += tiles.Length;
                }
                else
                {
                    secondBoatTiles += tiles.Length;
                }
                if(secondBoatTiles >= 50 || firstBoatTiles >= 50)
                {
                    break;
                }
            }
            if(firstBoatTiles > secondBoatTiles)
            {
                Console.WriteLine(firstBoat);
            }
            else if(secondBoatTiles > firstBoatTiles)
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
