﻿using System;

namespace _08._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double area = length * width;            
            double volume = (area * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
