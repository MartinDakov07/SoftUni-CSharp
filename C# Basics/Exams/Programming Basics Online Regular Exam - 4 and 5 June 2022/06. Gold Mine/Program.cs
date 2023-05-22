using System;

namespace _06._Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLocations = int.Parse(Console.ReadLine());
            double totalKilograms = 0;
            double kilograms = 0;
            
            double averageNeedGold = 0;
            int days = 0;
            for (int i = 0; i < numOfLocations; i++)
            {
                
                totalKilograms = 0;
                 averageNeedGold = double.Parse(Console.ReadLine());
                 days = int.Parse(Console.ReadLine());
                for (int j = 0; j < days; j++)
                {
                    kilograms = double.Parse(Console.ReadLine());
                    totalKilograms += kilograms;                
                }
                totalKilograms = totalKilograms / days;
                if (totalKilograms >= averageNeedGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {totalKilograms:f2}.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"You need {(averageNeedGold - totalKilograms):f2} gold.");
                    continue;
                }
            }
            
        }
    }
}
