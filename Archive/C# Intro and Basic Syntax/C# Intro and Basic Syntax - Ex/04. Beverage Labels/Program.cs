using System;

namespace _04._Beverage_Labels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double quantity = volume / 100;

            energy = energy * quantity;
            sugar = sugar * quantity;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy:f2}kcal, {sugar:f2}g sugars");
        }
    }
}
