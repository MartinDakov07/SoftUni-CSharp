﻿using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reversed = "";
            for(int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
