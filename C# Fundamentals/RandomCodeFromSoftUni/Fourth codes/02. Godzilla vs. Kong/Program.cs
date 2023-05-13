using System;

namespace _02._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statists = double.Parse(Console.ReadLine());
            double priceForClothes=double.Parse(Console.ReadLine());
            double dekor = budget * 0.1;
            double priceClothes = statists * priceForClothes;
            if(statists >= 150)
            {
                priceClothes = priceClothes - priceClothes * 0.1;
            }
            double totalPrice = priceClothes + dekor;
            if(totalPrice <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(budget - totalPrice):f2} leva left.");
            }
            else
            {
                
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(totalPrice - budget):f2} leva more.");
            }
        }
    }
}
