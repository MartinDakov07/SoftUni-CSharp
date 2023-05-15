using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20kg = double.Parse(Console.ReadLine());
            double amountOfLuggage = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numOfLuggage = int.Parse(Console.ReadLine());
            double price = 0;
            if(amountOfLuggage < 10)
            {
                price = priceAbove20kg - priceAbove20kg * 0.2;
            }
            else if(amountOfLuggage <= 20)
            {
                price = priceAbove20kg / 2;
            }
            else
            {
                price = priceAbove20kg;
            }
            if(days > 30)
            {
                price += price * 0.1;
            }
            else if(days <=30 && days >= 7)
            {
                price += price * 0.15;
            }
            else
            {
                price += price * 0.4;
            }
            double totalPrice = price * numOfLuggage;
            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv. ");

            

        }
    }
}
