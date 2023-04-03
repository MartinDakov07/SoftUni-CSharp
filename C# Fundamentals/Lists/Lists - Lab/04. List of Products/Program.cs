using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfProduct = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
                
            for(int i = 0; i < numOfProduct; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }
            products.Sort();
            for(int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");//if i = 0 -> i+1 = 1 (first time reading)
            }
        }
            
    }
}
