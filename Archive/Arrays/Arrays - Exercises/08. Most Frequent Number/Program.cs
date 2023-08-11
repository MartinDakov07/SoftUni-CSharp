using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _08._Most_Frequent_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToArray();
        int count = 0;
        int maxCount = 0;
        int bestNum = 0;
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                    if (count > maxCount)
                    {
                         maxCount = count;
                         maxCount = numbers[i];
                    }
                }
                else
                {
                    count = 0;
                }
            }
        }
        Console.WriteLine(string.Join(" ", maxCount));
        }
    }
}
