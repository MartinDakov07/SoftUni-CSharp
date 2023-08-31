using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _04._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            if (numbers.Count == 1)
            {
                Console.WriteLine(String.Join(" ", numbers));
                return;
            }
            int[] length = new int[numbers.Count];
            int[] previous = new int[numbers.Count];
            

            int lastIndex = -1;
            int maxLength = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                length[i] = 1;
                previous[i] = -1;
                for (int left = 0; left < i; left++)
                {
                    if (numbers[left] < numbers[i] && length[left] + 1 > length[i])//if the number on the right is lower, that means we will have the same length as our current number, that's why we will skip that lower num
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
            List<int> longestSequence = new List<int>(maxLength);
            while(lastIndex != -1)
            {
                longestSequence.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestSequence.Reverse();

            Console.WriteLine(String.Join(" ", longestSequence));
        }
            }
        }
