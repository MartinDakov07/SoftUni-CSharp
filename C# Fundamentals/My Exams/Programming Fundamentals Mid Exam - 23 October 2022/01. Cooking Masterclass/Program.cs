using System;

namespace _01._Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal packageOfFlour = decimal.Parse(Console.ReadLine());
            decimal priceForEgg = decimal.Parse(Console.ReadLine());
            decimal forOneApron = decimal.Parse(Console.ReadLine());             
            decimal priceForEggs = priceForEgg * 10m;
            decimal freePackages = students / 5;
            decimal totalPrice = forOneApron * Math.Ceiling(students+students*0.2m) + priceForEggs * students + packageOfFlour * (students - freePackages);
            if(budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(totalPrice - budget):f2}$ more needed.");
            }

        }
    }
}
