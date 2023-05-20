using System;

namespace _02._Beer_And_Chips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fan = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numOfBeer = int.Parse(Console.ReadLine());
            int numOfChips = int.Parse(Console.ReadLine());
            double priceForBeer = numOfBeer * 1.20;
            double priceForPacketChips =priceForBeer * 0.45;
            double totalPriceForChips = Math.Ceiling (numOfChips * priceForPacketChips);
            double totalPrice = priceForBeer + totalPriceForChips;
            double leftMoney = budget - totalPrice;
            double neededMoney = totalPrice - budget;
            if(budget >= totalPrice)
            {
                Console.WriteLine($"{fan} bought a snack and has {leftMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{fan} needs {Math.Abs(neededMoney):f2} more leva!");
            }

        }
    }
}
