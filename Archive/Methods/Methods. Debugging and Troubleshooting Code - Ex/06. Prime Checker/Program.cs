using System;
using System.Reflection;

namespace _06._Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }
        static bool IsPrime(long number)
        {
            number = Math.Abs(number);
            if(number == 2)
            {
                return true;
            }
            else if(number == 1 || number == 0)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
                
            }
                        
            return true;
            
            
            
        }
    }
}
