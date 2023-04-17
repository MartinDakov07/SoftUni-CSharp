using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string letters = "";
            string chars = "";
            string digits = "";
            foreach(char symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else 
                {
                    chars += symbol;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
    }
}
