using System;

namespace _05._Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyGoal = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string typeOfInput = String.Empty;
            int price = 0;
            int totalPrice = 0;
            while (input != "closed" || moneyGoal >= totalPrice)
            {
                
                typeOfInput = Console.ReadLine();
                if (input == "haircut")
                {
                    price = 0;
                    if (typeOfInput == "mens")
                    {
                        price = 15;
                    }
                    else if (typeOfInput == "ladies")
                    {
                        price = 20;
                    }
                    else if (typeOfInput == "kids")
                    {
                        price = 10;
                    }
                }
                else if (input == "color")
                {
                    price = 0;
                    if (typeOfInput == "touch up")
                    {
                        price = 20;
                    }
                    else if (typeOfInput == "full")
                    {
                        price = 30;
                    }
                }
                if(typeOfInput == "haircut" || typeOfInput == "color")
                {                                   
                    continue;
                }
                totalPrice += price;

                                                           //vhod 50,color,full,color,haircut,ladies

                input = Console.ReadLine();
               

                
                
            }
            if (totalPrice >= moneyGoal)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {totalPrice}lv.");

            }
            if (input == "closed")
            {
                Console.WriteLine($"Target not reached! You need {moneyGoal - totalPrice}lv. more.");
                Console.WriteLine($"Earned money: {totalPrice}lv.");
            }
        }
    }
}
