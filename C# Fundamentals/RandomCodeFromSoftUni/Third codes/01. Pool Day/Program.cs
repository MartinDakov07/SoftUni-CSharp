using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double priceForLounger = double.Parse(Console.ReadLine());
            double priceForUmbrella = double.Parse(Console.ReadLine());
            double totalPriceFee = people * price;
            double numPeopleLounger = Math.Ceiling(people * 0.75);
            double totalPriceLounger = numPeopleLounger * priceForLounger;
            double numPeopleUmbrella = Math.Ceiling(people * 0.5);
            double totalPriceUmbrella = numPeopleUmbrella * priceForUmbrella;
            double totalPrice = totalPriceFee + totalPriceLounger + totalPriceUmbrella;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
