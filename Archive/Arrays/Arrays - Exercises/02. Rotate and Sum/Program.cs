using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _02._Rotate_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            for(int i =0; i < k; i++)
            {
                int firstNum = numbers[numbers.Length - 1];
                for(int j = numbers.Length-1;j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = firstNum;
                for(int l = 0; l < numbers.Length; l++)
                {
                    sum[l] += numbers[l];
                }
            }
            Console.WriteLine(String.Join(" ",sum));
        }
    }
}
