using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _01._Array_Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            long lowestNum = long.MaxValue;
            long biggestNum = long.MinValue;
            double sum = 0;
            double average = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (numbers[i] > biggestNum)
                {
                    biggestNum = numbers[i];
                }
                if (numbers[i] < lowestNum) 
                {
                    lowestNum = numbers[i];
                }
            }
            average = sum / numbers.Length;
            Console.WriteLine($"Min = {lowestNum}");
            Console.WriteLine($"Max = {biggestNum}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
