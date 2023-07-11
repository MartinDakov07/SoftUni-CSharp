using System;
using System.Linq;

namespace _09._Reversed_chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            string text = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();
            string newText = "";
            //FirstCase
            //text = text.Reverse().ToString();            
            for(int i = text.Length - 1; i >= 0; i--)
            {
                 newText += text[i].ToString();
            }
            //ThirdCase- with foreach
            Console.WriteLine(newText);
        }
    }
}
