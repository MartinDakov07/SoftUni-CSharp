using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _06._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int start = 0;
            int count = 1;
            int bestCount = int.MinValue;            
            for(int i = 1; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    
                }
                else
                {                    
                    count = 1;
                }
                if (count > bestCount)
                {
                    start = i;
                    bestCount = count;
                }
            }
            int[] sequence = new int[bestCount];
            int index = 0;
            for(int i = 0; i < bestCount; i++)
            {
                sequence[index++] = numbers[start--];//if we write only start instead of start--, it will be same, because we will print the best num n times
            }
            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
