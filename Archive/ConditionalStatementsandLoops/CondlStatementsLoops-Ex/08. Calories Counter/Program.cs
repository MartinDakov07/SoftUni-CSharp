using System;

namespace _08._Calories_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            for(int i = 0; i < n; i++)
            {
                string product = Console.ReadLine().ToLower();
                if(product == "cheese")
                {
                    totalCalories += 500;
                }
                else if(product == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if(product == "salami")
                {
                    totalCalories += 600;
                }
                else if(product == "pepper")
                {
                    totalCalories += 50;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
