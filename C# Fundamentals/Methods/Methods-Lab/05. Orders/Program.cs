using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            int productsBought = int.Parse(Console.ReadLine());
            ProductPrice(product, productsBought);
            

        }

        private static void ProductPrice(string product, int productsBought)
        {
            if (product == "coffee")
            {
                Console.WriteLine($"{(1.50 * productsBought):f2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{(1.00 * productsBought):f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{(1.40 * productsBought):f2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{(2.00 * productsBought):f2}");
            }
        }

       
            
            
            

            
        

        
    }
}
