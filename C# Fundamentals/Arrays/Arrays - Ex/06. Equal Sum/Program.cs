using System;
using System.Linq;
namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            if(numbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
            
                rightSum = 0;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                leftSum = 0;
                for(int k = i - 1; k>=0; k--)
                {
                    leftSum += numbers[k];
                }
                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            
            
              Console.WriteLine("no");

        }
    }
}
