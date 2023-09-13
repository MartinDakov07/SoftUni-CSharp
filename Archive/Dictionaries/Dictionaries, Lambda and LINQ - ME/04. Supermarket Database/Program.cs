using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _04._Supermarket_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productPrice = new Dictionary<string, double>();
            Dictionary<string, long> productQuantity = new Dictionary<string, long>();
            string productInput = Console.ReadLine();
            while(productInput != "stocked")
            {
                string[] productArg = productInput.Split();
                string name = productArg[0];
                double price = double.Parse(productArg[1]);
                long quantity = long.Parse(productArg[2]);
                if (!productPrice.ContainsKey(name))
                {
                    productPrice[name] = price;
                    productQuantity[name] = 0;
                }

                productPrice[name] = price;
                productQuantity[name] += quantity;
                productInput = Console.ReadLine();
            }
            double total = 0;
            foreach (var product in productPrice)
            {
                foreach(var productName in productQuantity)
                {
                    if(product.Key == productName.Key)
                    {
                        double productTotalPrice = product.Value * productName.Value;
                        total += productTotalPrice;
                        Console.WriteLine($"{product.Key}: ${product.Value:f2} * {productName.Value} = ${productTotalPrice:f2}");
                    }
                }
            }
            Console.WriteLine(new string('-',30));
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
