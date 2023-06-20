using System;

namespace _05._Character_Stats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int leftHealth = maxHealth - currHealth;
            int leftEnergy = maxEnergy - currEnergy;

            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: |");
            for(int i = 0; i< currHealth; i++)
            {
                Console.Write("|");
            }
            for(int i = 0; i < leftHealth; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            Console.WriteLine();

            Console.Write($"Energy: |");
            for (int i = 0; i < currEnergy; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < leftEnergy; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");
        }
    }
}
