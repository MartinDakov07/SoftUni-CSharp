using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            Dictionary<string, long> productsQuantity = new Dictionary<string, long>();
            string info = Console.ReadLine();
            while(info != "stocked")
            {
                string[] infoArg = info.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = infoArg[0];
                double price = double.Parse(infoArg[1]);
                long quantity = long.Parse(infoArg[2]);
                if (!productsPrice.ContainsKey(product))
                {
                    productsPrice.Add(product, price);
                    productsQuantity.Add(product, 0);
                }
                productsPrice[product] = price;
                productsQuantity[product] += quantity;
                info = Console.ReadLine();
            }
            double totalPrice = 0;
            foreach(var price in productsPrice)
            {
                foreach(var quantity in productsQuantity)
                {
                    if(price.Key == quantity.Key)
                    {
                        double total = price.Value  * quantity.Value;
                        Console.WriteLine($"{price.Key}: ${price.Value:f2} * {quantity.Value} = ${total:f2}");
                        totalPrice += total;
                    }
                }
            }
            Console.WriteLine($"{new string('-',30)}");
            Console.WriteLine($"Grand Total: ${totalPrice:f2}");
        }
    }
}
