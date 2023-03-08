using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string flower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            switch (flower)
            {
               
                case "Roses":
                    price = num * 5;
                    if (num > 80)
                    {
                        price *= 0.9;
                    }      
                    break;
                case "Dahlias":
                    price = num * 3.8;
                    if (num > 90)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Tulips":
                    price = num * 2.8;
                    if(num > 80)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Narcissus":
                    price = num * 3;
                    if (num < 120)
                    {
                        price *= 1.15; ;
                    }
                    break;
                case "Gladiolus":
                    price = num * 2.5;
                    if (num < 80)
                    {
                        price *=1.2;
                    }
                    break;                   
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flower} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
            }            
        }
    }
}
