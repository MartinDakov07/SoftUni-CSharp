using System;

namespace _09._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(Math.Abs(result));
        }
        private static int GetOddSum(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int lastDigit = number % 10;
                if(lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        private static int GetEvenSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int evenSum = GetEvenSum(n);
            int oddSum = GetOddSum(n);            
            return oddSum * evenSum;
        }
    }
}
