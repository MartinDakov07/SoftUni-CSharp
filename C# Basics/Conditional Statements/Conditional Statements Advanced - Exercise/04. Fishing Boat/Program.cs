﻿using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double price = 1.00;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }
            if (fishermans <= 6)
            {
                price = price - price * 0.1;
            }
            else if ( fishermans <= 11)
            {
                price = price - price * 0.15;
            }
            else if (fishermans >= 12)
            {
                price = price - price * 0.25;
            }


            if (fishermans % 2 == 0 && season != "Autumn")
            {
                price = price - price * 0.05;
            }


            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
