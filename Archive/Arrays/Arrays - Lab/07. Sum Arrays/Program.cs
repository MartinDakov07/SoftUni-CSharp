using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _07._Sum_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int longerLength = Math.Max(firstNum.Length, secondNum.Length);
            int minLength = Math.Min(firstNum.Length, secondNum.Length);
            if(longerLength == minLength)
            {
                int[] sum = new int[longerLength];
                for(int i = 0; i < firstNum.Length; i++)//we can use and secondNum.Length, or longerLength, or minLength - they are all the same!
                {
                    sum[i] = firstNum[i] + secondNum[i];
                }
                Console.Write(string.Join(" ",sum));
            }
            else
            {
                int[] sum = new int[longerLength];
                for(int i = 0; i < longerLength; i++)
                {
                    if(i >= minLength)
                    {
                        if (firstNum.Length > secondNum.Length)
                        {
                            sum[i] = firstNum[i] + secondNum[i % minLength];
                        }
                        else if (secondNum.Length > firstNum.Length)
                        {
                            sum[i] = firstNum[i % minLength] + secondNum[i];
                        }
                    }
                    else
                    {
                        sum[i] = firstNum[i] + secondNum[i];
                    }                    
                }
                Console.Write(string.Join(" ",sum));
            }
        }
    }
}
