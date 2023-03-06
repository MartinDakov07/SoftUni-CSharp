using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading from the console the number for every toy
            double priceForHoliday = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            int allToys = puzzle + doll + bear + minion + truck;
            //Zapisvame cenite na vsqka igrachka
            double pricePuzzle = 2.60 * puzzle;
            double priceDoll = 3.00 * doll;
            double priceBear = 4.10 * bear;
            double priceMinion = 8.20 * minion;
            double priceTruck = 2.00 * truck;
            double priceForAllToys = pricePuzzle + priceDoll + priceBear + priceMinion + priceTruck;
            if (allToys >= 50)
            {
                priceForAllToys = priceForAllToys * 0.75;
            }
            priceForAllToys = priceForAllToys * 0.9;
            double difference = priceForAllToys - priceForHoliday;
            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):F2} lv needed.");
            }
        }
    }
}
