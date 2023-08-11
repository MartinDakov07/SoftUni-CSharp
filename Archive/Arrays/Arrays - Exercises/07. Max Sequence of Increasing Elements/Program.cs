using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _07._Max_Sequence_of_Increasing_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int count = 1;
            int bestSequence = int.MinValue;
            int start = 0;
            for (int i = 1; i <= numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    count++;

                }
                else
                {
                    count = 1;
                }
                if (count > bestSequence)
                {
                    bestSequence = count;
                    start = i - bestSequence + 1;
                }
            }
            int[] bestNums = new int[bestSequence];
            int index = 0;
            for (int i = 0; i < bestSequence; i++)
            {
                bestNums[index++] = numbers[start++];
            }
            Console.WriteLine(string.Join(" ", bestNums));
        }
    }
}
