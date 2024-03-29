﻿using System;
using System.Text;
namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string text = Console.ReadLine();
            char previousChar = text[0];
            sb.Append(previousChar);
            for(int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];
                if(previousChar != currChar)
                {
                    previousChar = currChar;
                    sb.Append(previousChar);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
