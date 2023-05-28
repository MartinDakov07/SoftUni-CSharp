using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numOfNights = int.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());
            double sale = double.Parse(Console.ReadLine()) / 100;
            if (numOfNights > 7)
            {
                priceForNight =priceForNight - priceForNight * 0.05;
            }
            double priceForAllNights = priceForNight * numOfNights;
            double otherPrice = budget * sale;
            double totalPrice = otherPrice + priceForAllNights;
            if(budget >= totalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalPrice:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(totalPrice - budget):f2} leva needed.");
            }
        }
    }
}
