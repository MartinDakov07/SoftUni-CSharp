using System;

namespace _04._Cat_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCats = int.Parse(Console.ReadLine());
            double grams = 0;
            double totalGrams = 0;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            for(int i = 0; i < numOfCats; i++)
            {
                grams = int.Parse(Console.ReadLine());
                if(grams >= 100 && grams < 200)
                {
                    group1++;
                }
                else if(grams >= 200 && grams < 300)
                {
                    group2++;
                }
                else
                {
                    group3++;
                }
                totalGrams += grams;
            }
            totalGrams = totalGrams / 1000;
            double priceForFoodPerDay = totalGrams * 12.45;
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {priceForFoodPerDay:f2} lv.");
        }
    }
}
