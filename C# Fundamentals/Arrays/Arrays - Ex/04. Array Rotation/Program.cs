using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            int[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            if(rotations == numbers.Length)
            {
                Console.WriteLine(String.Join(" ",numbers));
                return;
            }
            
            for(int i = 1; i <= rotations; i++)
            {
                int firstNum = numbers[0];
                for(int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Length - 1] = firstNum;
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
