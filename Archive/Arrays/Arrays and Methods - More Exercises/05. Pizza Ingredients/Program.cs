using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Pizza_Ingredients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split();
            int length = int.Parse(Console.ReadLine());
            int count = 0;
            List<string> recipe = new List<string>();
            for(int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == length)
                {
                    if (count >= 10)
                    {
                        break;
                    }
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    recipe.Add(ingredients[i]);
                    count++;
                }               
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",recipe)}.");
        }
    }
}
