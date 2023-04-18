using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedString = "";
            ShiftLetter(text, encryptedString);
        }
        private static void ShiftLetter(string text, string encryptedString)
        {
            foreach(char currChar in text)
            {
                int currPosition = currChar;
                currPosition += 3;
                encryptedString += (char)currPosition;
            }
            Console.WriteLine(encryptedString);
        }
    }
}
