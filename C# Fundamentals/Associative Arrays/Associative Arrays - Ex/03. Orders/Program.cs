using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            string[] product = Console.ReadLine().Split();
            while(product[0] != "buy")
            {
                
                
                string name = product[0];
                double price = double.Parse(product[1]);
                int quantity = int.Parse(product[2]);
                
                if (!products.ContainsKey(name))
                {
                    products.Add(name, new List<double>());
                    products[name].Add(price);
                    products[name].Add(quantity);
                }
                else
                {
                    products[name][1] += quantity;
                    products[name][0] = price;
                   
                }
                
                product = Console.ReadLine().Split();
            }
            foreach(var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}
