﻿using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            for(int i = 1; i <= n; i++)
            {
                int sum = 0;

                currentNumber = i;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }
                if(sum == 5 ||sum == 7|| sum == 11)
                {
                    Console.WriteLine($"{i} -> True ");
                }
                else
                {
                    Console.WriteLine($"{i} -> False ");
                }
            }
        }
    }
}
