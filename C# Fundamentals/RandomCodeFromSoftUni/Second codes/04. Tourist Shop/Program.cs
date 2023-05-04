using System;

namespace _04._Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            double productPrice = 0;
            string product = Console.ReadLine();
            int productCount = 0;
            while (product != "Stop")
            {                 
                productPrice = double.Parse(Console.ReadLine());
               
                productCount++;
                if (productCount % 3 == 0)
                {
                    productPrice = productPrice / 2;
                }           
                
                if(productPrice >= budget)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {(productPrice - budget):f2} leva!");
                    break;
                }
                price += productPrice;
                budget -= price;
                product = Console.ReadLine();
            }
           
           if(product == "Stop")
            {
                Console.WriteLine($"You bought {productCount} products for {price:f2} leva.");
            }
                
            
           
            
            
        }
    }
}
