using System;

namespace _03._Oscars_week_in_cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string typePlace = Console.ReadLine();
            int numViewers = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            if(film == "A Star Is Born")
            {
                if(typePlace == "normal")
                {
                    price = 7.50;
                }
                else if(typePlace == "luxury")
                {
                    price = 10.50;
                }
                else if(typePlace == "ultra luxury")
                {
                    price = 13.50;
                }
            }
            else if (film == "Bohemian Rhapsody")
            {
                if (typePlace == "normal")
                {
                    price = 7.35;
                }
                else if (typePlace == "luxury")
                {
                    price = 9.45;
                }
                else if (typePlace == "ultra luxury")
                {
                    price = 12.75;
                }
            }
            else if (film == "Green Book")
            {
                if (typePlace == "normal")
                {
                    price = 8.15;
                }
                else if (typePlace == "luxury")
                {
                    price = 10.25;
                }
                else if (typePlace == "ultra luxury")
                {
                    price = 13.25;
                }
            }
            else if (film == "The Favourite")
            {
                if (typePlace == "normal")
                {
                    price = 8.75;
                }
                else if (typePlace == "luxury")
                {
                    price = 11.55;
                }
                else if (typePlace == "ultra luxury")
                {
                    price = 13.95;
                }
            }
            totalPrice = price * numViewers;
            Console.WriteLine($"{film} -> {totalPrice:f2} lv.");
        }
    }
}
