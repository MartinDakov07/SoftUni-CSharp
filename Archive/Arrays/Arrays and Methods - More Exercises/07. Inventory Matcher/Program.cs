using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _07._Inventory_Matcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal [] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            string product = Console.ReadLine();
            while(product != "done")
            {
                for(int i = 0; i < products.Length; i++)
                {
                    if (products[i] == product)
                    {
                        Console.WriteLine($"{products[i]} costs: {price[i]}; Available quantity: {quantity[i]}");
                    }
                }
                product = Console.ReadLine();
            }
        }
    }
}
