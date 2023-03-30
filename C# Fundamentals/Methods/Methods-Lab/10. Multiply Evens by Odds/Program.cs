using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int odd = GetSumOfOddDigits(number);
            int even = GetSumOfEvenDigits(number);
            int result =GetMultipleOfEvenAndOdds(odd, even);
            Console.WriteLine(result);
            
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int digit = number;
            
            while(digit > 0)
            {
                int currDigit = digit % 10;
                if(currDigit % 2 == 0)
                {
                    sum += currDigit;
                }

                digit = digit / 10;
            }
            return sum;         
        }
        static int GetSumOfOddDigits(int number)
        {
            int digit = number;
            int sum = 0;
            while( digit > 0)
            {
                int currDigit = digit % 10;
                if(currDigit % 2 != 0)
                {
                    sum += currDigit;
                }
                digit = digit / 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int odd, int even)
        {
            return odd * even;
            
        }

    }
}
