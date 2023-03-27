using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        
            int equalNumsCount = 1;
            int longestNums = int.MinValue;
            int bestNum = 0;
        
            for (int i = 0; i < numbers.Length; i++)
            {
                equalNumsCount = 1;
        
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        equalNumsCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (equalNumsCount > longestNums)
                {
                    longestNums = equalNumsCount;
                    bestNum = i;
                }
        
            }
            for (int k = 0; k < longestNums; k++)
            {
                Console.Write(numbers[bestNum] + " ");
            }
        }
    }
}
