using System;

namespace _11._Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (true)
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    return;
                }
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
