using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());
            double chickensPrice = chickenMenus * 10.35;
            double fishesPrice = fishMenus * 12.40;
            double vegetariansPrice = vegetarianMenus * 8.15;
            double totalPrice = chickensPrice + fishesPrice + vegetariansPrice;
            double sale = totalPrice * 0.2;
            double priceForHome = 2.50;
            double totalPriceForAll = totalPrice + sale + priceForHome;
            Console.WriteLine(totalPriceForAll);
        }
    }
}
