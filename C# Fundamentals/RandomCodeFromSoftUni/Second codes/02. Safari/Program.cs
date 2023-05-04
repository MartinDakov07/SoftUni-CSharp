using System;

namespace _02._Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double priceForLiter = 2.10;
            int priceEkskurzovod = 100;
            double totalPriceForGas = liters * 2.10;
            double totalPrice = totalPriceForGas + priceEkskurzovod;
            if(day == "Saturday")
            {
                totalPrice = totalPrice - totalPrice * 0.1;
            }
            else if (day == "Sunday")
            {
                totalPrice = totalPrice - totalPrice * 0.2;
            }

            if(budget >= totalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {(budget - totalPrice):f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {(totalPrice - budget ):f2} lv.");
            }
        }
    }
}
