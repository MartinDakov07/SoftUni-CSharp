using System;

namespace _03._Final_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            string place = Console.ReadLine();
            double moneyPrice = 0;
            if(place == "Bulgaria")
            {
                moneyPrice = numOfDancers * points;
                if(season == "winter")
                {
                    moneyPrice = moneyPrice - moneyPrice * 0.08;
                }
                else if(season == "summer")
                {
                    moneyPrice = moneyPrice - moneyPrice * 0.05;
                }
            }
            else if (place == "Abroad")
            {
                moneyPrice = numOfDancers * points;
                moneyPrice = moneyPrice + moneyPrice * 0.5;
                if (season == "winter")
                {
                    moneyPrice = moneyPrice - moneyPrice * 0.15;
                }
                else if (season == "summer")
                {
                    moneyPrice = moneyPrice - moneyPrice * 0.1;
                }
            }
            double moneyForCharity = moneyPrice * 0.75;
            double leftMoney = moneyPrice - moneyForCharity;
            double moneyPerDancer = leftMoney / numOfDancers;
            Console.WriteLine($"Charity - {moneyForCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
           
           
        }
    }
}
