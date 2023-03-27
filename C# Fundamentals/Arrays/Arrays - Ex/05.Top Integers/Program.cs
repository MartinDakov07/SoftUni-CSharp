﻿using System;
using System.Linq;
namespace _05.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                bool isTopInt = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if (nextNum >= currNum)
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
