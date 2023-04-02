using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            FindWhatResultIS(num1,num2, num3);
        }
        static void PositiveNumber(int num1, int num2, int num3)
        {
            Console.WriteLine("positive");              
        }
        static void NegativeNumber(int num1, int num2, int num3)
        {
            Console.WriteLine("negative"); 
        }
        static void Zero(int num1, int num2, int num3)
        {
            Console.WriteLine("zero"); 
        }
        static void FindWhatResultIS(int num1, int num2, int num3)
        {
            int negativeCounter = 0;
            if (num1 < 0)
            {
                negativeCounter++;
            }
            if (num2 < 0)
            {
                negativeCounter++;
            }
            if (num3 < 0)
            {
                negativeCounter++;
            }
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Zero(num1, num2, num3);
                return;
            }
            if (negativeCounter == 0)
            {
                PositiveNumber(num1, num2, num3);                
            }
            else if (negativeCounter == 1)
            {
                NegativeNumber(num1, num2, num3);               
            }
            else if (negativeCounter == 2)
            {
               PositiveNumber(num1, num2, num3);               
            }
            else 
            {
               NegativeNumber(num1, num2, num3);                
            }
            
        }
    }
}
