using System;

namespace _05._Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            string coctail = Console.ReadLine();
            int numCoctails = 0;
            double price = 0;
            double totalPrice = 0;
            double coctailPrice = 0;
            while(coctail != "Party!")
            {
                coctailPrice = 0;
                price = 0;
                numCoctails = int.Parse(Console.ReadLine());
                price = coctail.Length;
                coctailPrice = price * numCoctails;
                if (coctailPrice % 2 != 0)
                {
                    coctailPrice = coctailPrice - coctailPrice * 0.25;
                }
                totalPrice += coctailPrice;
                if(totalPrice >= neededMoney)
                {
                    break;
                }
                coctail = Console.ReadLine();
            }
            if(coctail == "Party!")
            {
                Console.WriteLine($"We need {(neededMoney - totalPrice):f2} leva more.");
            }
            else if(totalPrice >= neededMoney)
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {totalPrice:f2} leva.");
        }
    }
}
