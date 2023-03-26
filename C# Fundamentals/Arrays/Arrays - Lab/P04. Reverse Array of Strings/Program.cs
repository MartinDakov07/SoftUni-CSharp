using System;
using System.Linq;
namespace P04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var symbols = Console.ReadLine()
                .Split()               
                .ToArray();
            for(int i = symbols.Length - 1; i >= 0; i--)
            {
                Console.Write($"{symbols[i]} ");
            }

        }
    }
}
