﻿using System;

namespace _05._Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            switch (countryName)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");                   
                    break;
                case "Spain":
                case "Mexico":
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
