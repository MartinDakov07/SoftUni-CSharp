using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfString = Console.ReadLine();
            if(typeOfString == "int")
            {
                ReturnIntValue(typeOfString);
            }
            else if(typeOfString == "real")
            {
                ReturnRealValue(typeOfString);
            }
            else
            {
                ReturnStringValue(typeOfString);
            }
            
        }
        static void ReturnIntValue(string typeOfString)
        {                      
           int value = int.Parse(Console.ReadLine());
            value = value * 2;
            Console.WriteLine(value);
        }
        static void ReturnRealValue(string typeOfString)
        {
            double value = double.Parse(Console.ReadLine());
            value = value * 1.5;
            Console.WriteLine($"{value:f2}");
        }
        static void ReturnStringValue(string typeOfString)
        {
            string value = Console.ReadLine();
            Console.WriteLine($"${value}$");
        }

    }
}
