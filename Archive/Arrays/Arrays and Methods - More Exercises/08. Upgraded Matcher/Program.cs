using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _08._Upgraded_Matcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            string productInfo = Console.ReadLine();
            while(productInfo != "done")
            {
                string[] productArg = productInfo.Split();
                string product = productArg[0];
                long quantity = long.Parse(productArg[1]);
                for(int i = 0; i < products.Length; i++)
                {
                    if (products[i] == product)
                    {
                        if(i < 0 || i > quantities.Length - 1)
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                        }
                        else
                        {
                            if (quantities[i] - quantity < 0)
                            {
                                Console.WriteLine($"We do not have enough {products[i]}");
                            }
                            else
                            {
                                Console.WriteLine($"{products[i]} x {quantity} costs {(quantity * prices[i]):f2}");
                                quantities[i] -= quantity;
                            }
                        }
                        break;
                    }                    
                }
                productInfo = Console.ReadLine();
            }
        }
    }
}
