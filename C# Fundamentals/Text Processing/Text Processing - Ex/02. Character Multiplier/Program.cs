using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections.Generic;
namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            GetStringSum(input[0], input[1]);
        }
       private static void GetStringSum(string inputOne, string inputTwo)
       {
            int sum = 0;
            int minLength = Math.Min(inputOne.Length, inputTwo.Length);
            for(int i = 0; i < minLength; i++)
            {
                sum += inputOne[i] * inputTwo[i];
            }
            string longerLength = inputOne;
            if(longerLength.Length < inputTwo.Length)
            {
                longerLength = inputTwo;
            }
            for(int i = minLength; i < longerLength.Length; i++)
            {
                sum+=longerLength[i];
            }
            Console.WriteLine(sum);
       }
    }
}
