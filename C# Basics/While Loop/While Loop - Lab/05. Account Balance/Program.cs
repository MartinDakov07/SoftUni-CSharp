using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            double totalAmount = 0;
            while (inputWord != "NoMoreMoney")
            {
                double currentAmount = double.Parse(inputWord);
                if (currentAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {currentAmount:f2}");
                totalAmount += currentAmount;
                inputWord = Console.ReadLine();
                
            }
            if (totalAmount >= 0)
            {
                Console.WriteLine($"Total: {totalAmount:f2}");
            }
           
        }
    }
}
