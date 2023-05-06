using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            if(nights > 7)
            {
                priceForNight = priceForNight - priceForNight * 0.05;
            }
            double totalPriceNight = priceForNight * nights;
            double otherThings = (percent/100) * budget;
            double totalPrice = totalPriceNight + otherThings;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget - totalPrice):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(totalPrice - budget):f2} leva needed.");
            }
        }
    }
}
