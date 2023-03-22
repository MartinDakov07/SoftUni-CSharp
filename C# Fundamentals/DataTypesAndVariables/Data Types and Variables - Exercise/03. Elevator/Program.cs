﻿using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = (int)(people / capacity);
            if(people % capacity != 0)
            {
                courses++;
            }
            Console.WriteLine($"{courses}");
        }
    }
}
