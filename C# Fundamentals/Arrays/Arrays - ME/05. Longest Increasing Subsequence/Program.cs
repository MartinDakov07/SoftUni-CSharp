using System;
using System.Linq;
namespace _05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if(numbers.Length == 1)
            {
                Console.WriteLine(String.Join(" ", numbers));
                return;
            }
            int[] length = new int[numbers.Length];
            int[] previous = new int[numbers.Length];
            int[] longestSequence;
            
            int lastIndex = -1;
            int maxLength = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                previous[i] = -1;
                for (int left = 0; left < i; left++)
                {
                    if (numbers[left] < numbers[i] && length[left] >= length[i])
                    {
                        length[i] = 1 + length[left];
                        previous[i] = left;
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
            longestSequence = new int[maxLength];
            for (int index = 0; index < maxLength; index++)
            {
                longestSequence[index] = numbers[lastIndex];
                lastIndex = previous[lastIndex];
            }
            
            Array.Reverse(longestSequence);
            
            Console.WriteLine(String.Join(" ", longestSequence));
            
        }
    }
}
