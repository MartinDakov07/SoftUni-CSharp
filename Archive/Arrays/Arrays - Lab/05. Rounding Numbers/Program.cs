using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _05._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int count = 0;
            foreach(var num in numbers)
            {
                double number = num + 0.5;
                if(number % 1 == 0.5)
                {
                    number = Math.Ceiling(Math.Abs(number));
                }
                numbers[count++] = Math.Abs(number);
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
