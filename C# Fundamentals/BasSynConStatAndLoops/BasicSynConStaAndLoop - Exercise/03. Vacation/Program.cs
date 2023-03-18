using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            if(typeGroup == "Students")
            {
                if(day == "Friday")
                {
                    price = 8.45;
                }
                else if(day == "Saturday")
                {
                    price = 9.80;
                }
                else if(day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }
            
            if(typeGroup == "Students")
            {
                if(people >= 30)
                {
                    price = price - price * 0.15;
                }
            }
            else if(typeGroup == "Business")
            {
                if(people >= 100)
                {
                    people -= 10;
                }
            }
            else if(typeGroup == "Regular")
            {
                if (people >= 10 && people <= 20)
                {
                    price = price - price * 0.05;
                }
            }
            totalPrice = price * people;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
