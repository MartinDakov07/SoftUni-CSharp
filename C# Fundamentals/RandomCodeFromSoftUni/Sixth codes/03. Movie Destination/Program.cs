using System;

namespace _03._Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int numOfDays = int.Parse(Console.ReadLine());
            int price = 0;
            if(destination == "Dubai")
            {
                if (season == "Winter")
                {
                    price = 45000;
                }
                else if(season == "Summer")
                {
                    price = 40000;
                }
            }
            else if (destination == "Sofia")
            {
                if(season == "Winter")
                {
                    price = 17000;
                }
                else if (season == "Summer")
                {
                    price = 12500;
                }
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    price = 24000;
                }
                else if (season == "Summer")
                {
                    price = 20250;
                }
            }
            double totalPrice = price * numOfDays;
            if(destination == "Dubai")
            {
                totalPrice = totalPrice - totalPrice * 0.3;
            }
            if(destination == "Sofia")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }

            if (budget > totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {(budget - totalPrice):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {Math.Abs(totalPrice - budget):f2} leva more!");
            }
        }
    }
}
