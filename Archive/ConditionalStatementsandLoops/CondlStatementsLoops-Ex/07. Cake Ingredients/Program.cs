using System;

namespace _07._Cake_Ingredients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product;
            int count = 0;
            while((product = Console.ReadLine()) != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {product}.");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
