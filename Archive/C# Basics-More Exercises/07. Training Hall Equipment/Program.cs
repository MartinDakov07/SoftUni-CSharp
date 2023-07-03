using System;

namespace _07._Training_Hall_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfItems = int.Parse(Console.ReadLine());
            double subtotal = 0;
            for(int i = 0; i < countOfItems; i++)
            {
                string item = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                double totalPrice = itemPrice * count;
                subtotal += totalPrice;
                if(count > 1)
                {
                    item += "s";
                }
                Console.WriteLine($"Adding {count} {item} to cart.");
            }
            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            if(subtotal > budget)
            {
                Console.WriteLine($"Not enough. We need ${(subtotal-budget):f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${(budget-subtotal):f2}");
            }
        }
    }
}
