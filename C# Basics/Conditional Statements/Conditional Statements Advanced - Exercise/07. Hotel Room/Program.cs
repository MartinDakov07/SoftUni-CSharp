using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            double priceForStudio =night;
            double priceForApartment = night;
            if (month == "May" || month == "October")
            {
                priceForApartment *= 65;
                priceForStudio *= 50;               
                if(night > 7 && night <= 14)
                {
                    priceForStudio *= 0.95;
                }
                else if (night > 14)
                {
                    priceForApartment *= 0.9;
                    priceForStudio *= 0.7;
                }                                                   
            }
            if (month == "June" || month == "September")
            {
                priceForApartment *= 68.70;
                priceForStudio *= 75.20;
                if(night >14)
                {
                    priceForApartment *= 0.9;
                    priceForStudio *= 0.8;                   
                }
            }
            if (month == "July" || month == "August")
            {
                priceForApartment *= 77;
                priceForStudio *= 76;
                if (night > 14)
                {
                    priceForApartment *= 0.9;
                }
            }
            Console.WriteLine($"Apartment: {priceForApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
            
        }
    }
}
