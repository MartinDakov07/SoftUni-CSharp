using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> occNumber = new SortedDictionary<double, int>();
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            foreach(var number in numbers)
            {
                if (!occNumber.ContainsKey(number))
                {
                    occNumber.Add(number, 0);
                }
                occNumber[number]++;
            }
            foreach(var number in occNumber)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
          
        }
    }
}
