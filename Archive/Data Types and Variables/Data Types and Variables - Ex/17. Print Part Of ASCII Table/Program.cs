﻿using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for(int i = num1; i <= num2; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
