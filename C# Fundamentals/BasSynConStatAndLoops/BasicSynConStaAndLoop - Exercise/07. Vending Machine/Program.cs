using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 0;
            double totalValue = 0;
            string product = Console.ReadLine();
            while(product != "Start")
            {
                value = double.Parse(product);
                if(value != 0.1 && value != 0.2 && value != 0.5 && value != 1 && value != 2)
                {
                    Console.WriteLine($"Cannot accept {value}");
                    value = 0;
                }
                totalValue += value; 
                product = Console.ReadLine();
            }
            string food = Console.ReadLine();
            double foodPrice = 0;
           
            while(food != "End")
            {
                if(food == "Nuts")
                {
                    foodPrice = 2;
                }
                else if(food == "Water")
                {
                    foodPrice = 0.7;
                }
                else if (food == "Crisps")
                {
                    foodPrice = 1.5;
                }
                else if (food == "Soda")
                {
                    foodPrice = 0.8;
                }
                else if (food == "Coke")
                {
                    foodPrice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if(food == "Nuts"|| food == "Water"|| food == "Crisps"|| food == "Soda"|| food == "Coke")
                {
                    if (totalValue >= foodPrice)
                    {
                        Console.WriteLine($"Purchased {food.ToLower()}");
                        totalValue = totalValue - foodPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        foodPrice = foodPrice - totalValue;
                    }
                }
                

                
                food = Console.ReadLine();
            }
            if(totalValue < 0)
            {
                totalValue = 0;
            }
            Console.WriteLine($"Change: {(totalValue):f2}");
        }
    }
}
