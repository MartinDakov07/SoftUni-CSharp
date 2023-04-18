using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1];
                string numAsString = item[1..^1];
                double numFromString = double.Parse(numAsString);
                if (char.IsUpper(firstLetter))
                {
                    int positionOfLetter = firstLetter - 64;
                    numFromString /= positionOfLetter;
                }
                else
                {
                    int positionOfLetter = firstLetter - 96;
                    numFromString *= positionOfLetter;
                }
                if (char.IsUpper(lastLetter))
                {
                    int positionOfLetter = lastLetter - 64;
                    numFromString -= positionOfLetter;
                }
                else
                {
                    int positionOfLetter = lastLetter - 96;
                    numFromString += positionOfLetter;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
