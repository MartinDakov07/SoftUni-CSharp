using System;

namespace _04._Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string vipRequirement = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            bool isDifferent = false;
            double price = 0;
            double totalPrice = 0;
            if(city == "Bansko" || city == "Borovets")
            {
                if(packet == "withEquipment")
                {
                    price = 100;
                    if (vipRequirement == "yes")
                    {
                        price = price - price * 0.1;
                    }
                }
                else if(packet == "noEquipment")
                {
                    price = 80;
                    if (vipRequirement == "yes")
                    {
                        price = price - price * 0.05;
                    }
                }
                else
                {
                    isDifferent = true;
                }
                
                
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (packet == "withBreakfast")
                {
                    price = 130;
                    if (vipRequirement == "yes")
                    {
                        price = price - price * 0.12;
                    }
                }
                else if (packet == "noBreakfast")
                {
                    price = 100;
                    if (vipRequirement == "yes")
                    {
                        price = price - price * 0.07;
                    }
                }
                else
                {
                    isDifferent = true;
                }
               
                
            }
            else
            {
                isDifferent = true;
            }
            if(days >= 7)
            {
                days--;
            }
            totalPrice = price * days;
            if (isDifferent)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days <= 0)
            {
                Console.WriteLine($"Days must be positive number!");
            }
            else
            {
                
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }
            

        }
    }
}
