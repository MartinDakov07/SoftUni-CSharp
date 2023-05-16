using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int maxGoal = 0;
            string bestPlayer = "";
            while(player != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if(maxGoal < goals)
                {
                    bestPlayer = player;
                    maxGoal = goals;
                }
                if(goals >= 10)
                {
                    break;
                }
                player = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if(maxGoal >= 3)
            {
                Console.WriteLine($"He has scored {maxGoal} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoal} goals.");
            }
                    
        }
    }
}
