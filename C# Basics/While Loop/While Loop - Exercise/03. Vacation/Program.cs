using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double currentSum = double.Parse(Console.ReadLine());
            int dayCount = 0;
            int spendCount = 0;
            string input = String.Empty;
            double spendOrSafe = 0;

            while (currentSum < holidayPrice)
            {
                input = Console.ReadLine();
                spendOrSafe = double.Parse(Console.ReadLine());
                dayCount++;

                if (input == "spend")
                {
                   
                    currentSum -= spendOrSafe;
                    if (currentSum < 0)
                    {
                        currentSum = 0;
                    }
                    spendCount++;
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(dayCount);
                        break;
                    }
                }              
                if (input == "save")
                {
                    currentSum += spendOrSafe;
                    spendCount = 0;
                }                                            
            }
            
            if (currentSum >= holidayPrice)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }
            
            
        }
    }
}
