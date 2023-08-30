using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _01._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int bestNumber = 0;
            int bestCount = -1;
            int count = 0;
            if(numbers.Count == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    bestNumber = numbers[i];
                }
            }
            List<int> longestSequence = numbers.Where(num => num == bestNumber).ToList();
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}

