using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numTicketsAdults = int.Parse(Console.ReadLine());
            int numTicketsKids = int.Parse(Console.ReadLine());
            double netPriceForAdult = double.Parse(Console.ReadLine());
            double priceHelp = double.Parse(Console.ReadLine());
            double netPriceKid = netPriceForAdult - netPriceForAdult * 0.7;
            double priceForAdult = netPriceForAdult + priceHelp;
            double priceForKid = netPriceKid + priceHelp;
            double totalPrice = (numTicketsAdults * priceForAdult) + (numTicketsKids * priceForKid);
            double leftPrice = totalPrice * 0.2;
            Console.WriteLine($"The profit of your agency from {name} tickets is {leftPrice:f2} lv.");

            
            
        }
    }
}
