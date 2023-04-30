using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentNum = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            while(currentNum != "stop")
            {
                int num = int.Parse(currentNum);
                if(num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isPrime = true;
                for(int i = 2; i < num; i++)
                {
                    if(num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
                currentNum = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

        }
    }
}
