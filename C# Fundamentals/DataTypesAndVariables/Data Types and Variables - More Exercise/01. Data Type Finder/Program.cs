﻿using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int integer;
            double floatingPoint;
            char character;
            bool isBool;
            while(input != "END")
            {
                 if(int.TryParse(input, out integer))
                 {
                    Console.WriteLine($"{input} is integer type");
                 }
                 else if(double.TryParse(input, out floatingPoint))
                 {
                    Console.WriteLine($"{input} is floating point type");
                 }
                 else if (char.TryParse(input, out character))
                 {
                    Console.WriteLine($"{input} is character type");
                 }
                 else if(bool.TryParse(input, out isBool))
                 {
                    Console.WriteLine($"{input} is boolean type");
                 }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
