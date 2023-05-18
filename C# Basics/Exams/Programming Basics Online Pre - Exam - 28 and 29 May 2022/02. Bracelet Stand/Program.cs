using System;

namespace _02._Bracelet_Stand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double priceMoney = double.Parse(Console.ReadLine());
            double razhods = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            double moneyForPeriod = moneyPerDay * 5;
            double wonMoney = priceMoney * 5;
            double totalMoney = (moneyForPeriod + wonMoney)-razhods;
          
            if(totalMoney > presentPrice)
            {
                Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {Math.Abs(presentPrice-totalMoney):f2} BGN.");
            }

        }
    }
}
