using System;

namespace _03._Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string beverage = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numDrinks = int.Parse(Console.ReadLine());
            double price = 0;
            if (beverage == "Espresso")
            {
                if (sugar == "Without")
                {
                    price = 0.9;
                }
                else if (sugar == "Normal")
                {
                    price = 1;
                }
                else if (sugar == "Extra")
                {
                    price = 1.2;
                }
            }
            if (beverage == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    price = 1.0;
                }
                else if (sugar == "Normal")
                {
                    price = 1.2;
                }
                else if (sugar == "Extra")
                {
                    price = 1.6;
                }
            }
            if (beverage == "Tea")
            {
                if (sugar == "Without")
                {
                    price = 0.5;
                }
                else if (sugar == "Normal")
                {
                    price = 0.6;
                }
                else if (sugar == "Extra")
                {
                    price = 0.7;
                }
            }
            if(sugar == "Without")
            {
                price = price - price * 0.35;
            }
            if(beverage == "Espresso" && numDrinks >= 5)
            {
                price = price - price * 0.25;
            }
            double totalPrice = price * numDrinks;
            if(totalPrice >= 15)
            {
                totalPrice = totalPrice - totalPrice * 0.2;
            }
            Console.WriteLine($"You bought {numDrinks} cups of {beverage} for {totalPrice:f2} lv.");
        }
    }
}
