using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Chetem ot konzolata budget,statisti,cena za tqh
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            // cena za dekor 10% ot budgeta
            double decor = budget * 0.10;
            double clothing = statists * clothingPrice;
            
            if (statists > 150)
            {
                clothingPrice = clothingPrice * 0.90;
            }
            else
            {
                clothing = clothingPrice;
            }
            double neededMoney = clothing + decor;
            double difference = budget - neededMoney;
            if (difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }
            
        }
    }
}
