using System;

namespace _03._Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool evenOrOddNum = number % 2 == 0;
            if (evenOrOddNum)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
