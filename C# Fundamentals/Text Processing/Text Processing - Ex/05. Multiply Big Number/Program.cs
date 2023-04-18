﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            int reminder = 0;
            if (multiplier == 0 || number == "0")
            {
                Console.WriteLine(0);
                return;
            }
            for(int i = number.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(number[i].ToString());
                int product = currDigit * multiplier + reminder;
                int result = product % 10;
                reminder = product / 10;
                sb.Insert(0, result);
            }
            if(reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
        }   
         
    }
}
