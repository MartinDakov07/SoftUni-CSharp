using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());
            double eatenBiscuits = 0;
            int eatenDogFood = 0;
            int eatenCatFood = 0;
            for (int i = 1; i <= days; i++)
            {
                int eatenByDog = int.Parse(Console.ReadLine());
                int eatenByCat = int.Parse(Console.ReadLine());
                eatenDogFood += eatenByDog;
                eatenCatFood += eatenByCat;
                if (i % 3 == 0)
                {
                    eatenBiscuits += (eatenByDog + eatenByCat) * 0.1;
                }
            }
            double totalFoodEaten = eatenDogFood + eatenCatFood;
            double total = totalFoodEaten / foodQuantity * 100;
            double totalDog = eatenDogFood / totalFoodEaten * 100;
            double totalCat = eatenCatFood / totalFoodEaten * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(eatenBiscuits)}gr.");
            Console.WriteLine($"{total:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDog:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCat:f2}% eaten from the cat.");
        }
    }
}
