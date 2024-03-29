﻿using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _06._Byte_Flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Where(x => x.Length == 2).ToArray();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                char[] charArray = numbers[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(System.Convert.ToChar(System.Convert.ToUInt32(new string(charArray), 16)));
            }
            Console.WriteLine();
        }
    }
}
