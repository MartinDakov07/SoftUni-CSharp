using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double number = numbers.Average();
            List<int> newNumbers = numbers.Where(x => x > number).ToList();
            List<int> orderedNumbers = newNumbers.OrderByDescending(x => x).ToList();
            if (newNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            if (orderedNumbers.Count > 5)
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.Write($"{orderedNumbers[i]} ");
                }
            }            
            else
            {
                Console.WriteLine(String.Join(" ",orderedNumbers));
            }
        }
    }
}
