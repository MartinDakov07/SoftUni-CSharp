using System;

namespace _05._Puppy_Care
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFoodBought = int.Parse(Console.ReadLine())*1000;
            string grams = Console.ReadLine();
            double gramsForDog = 0;
            double totalGrams = 0;
            while (grams != "Adopted") 
            {
                gramsForDog = double.Parse(grams);
                totalGrams += gramsForDog;
                
                
                    
                
                grams = Console.ReadLine();

            }
            if (totalFoodBought >= totalGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalFoodBought - totalGrams} grams.");
               
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(totalGrams - totalFoodBought)} grams more.");
                
            }
        }
    }
}
