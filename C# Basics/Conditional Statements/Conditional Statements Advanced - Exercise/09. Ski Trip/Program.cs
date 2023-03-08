using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //room for one person" – 18.00 лв за нощувка

               // "apartment" – 25.00 лв за нощувка

              // "president apartment" – 35.00 лв за нощувка
            int days = int.Parse(Console.ReadLine());
            days = days - 1;
            string place = Console.ReadLine();
            string rating = Console.ReadLine(); 

            double room = 18.00;
            double priceForRoom = room * days;
            double apartment = 25.00;
            double priceForApart = apartment * days;
            double presidenApar = 35.00;
            double priceForPres = presidenApar * days;
            double price = 0;
            if (days < 10)
            {
                if (place == "room for one person")
                {
                    price = priceForRoom;
                }
                else if (place == "apartment")
                {
                    price = priceForApart - priceForApart * 0.30;
                }
                else if (place == "president apartment")
                {
                    price = priceForPres - priceForPres * 0.10;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                if (place == "room for one person")
                {
                    price = priceForRoom;
                }
                else if (place == "apartment")
                {
                    price = priceForApart - priceForApart * 0.35;
                }
                else if (place == "president apartment")
                {
                    price = priceForPres - priceForPres * 0.15;
                }
            }
            else if (days > 15)
            {
                if (place == "room for one person")
                {
                    price = priceForRoom;
                }
                else if (place == "apartment")
                {
                    price = priceForApart - priceForApart * 0.50;
                }
                else if (place == "president apartment")
                {
                    price = priceForPres - priceForPres * 0.20; ;
                }
            }
            if (rating == "positive")
            {
                price = price + price * 0.25;
            }
            else if (rating == "negative")
            {
                price = price - price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
