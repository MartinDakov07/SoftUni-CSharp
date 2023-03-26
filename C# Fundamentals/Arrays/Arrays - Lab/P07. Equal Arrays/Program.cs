using System;
using System.Linq;
namespace P07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0;i < arr1.Length; i++)
            {
                sum1 += arr1[i];
                sum2 += arr2[i];
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }                
            }
            if(sum1 == sum2)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }
        }
    }
}
