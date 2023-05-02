using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;
            foreach(char c in text.Where(c=>c > (int)firstSymbol && c < (int)secondSymbol))
            {
                sum += (int)c;
            }
            Console.WriteLine(sum);
        }
    }
}
