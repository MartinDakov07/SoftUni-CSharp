using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double priceCapsule = 0;
            int days = 0;
            int capsules = 0;
            double totalPrice = 0;
            double price = 0;
            for(int i = 1; i <= orders; i++)
            {
                priceCapsule = 0;
                days = 0;
                capsules = 0;
                price = 0;
                priceCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsules = int.Parse(Console.ReadLine());
                price = (days * capsules) * priceCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
