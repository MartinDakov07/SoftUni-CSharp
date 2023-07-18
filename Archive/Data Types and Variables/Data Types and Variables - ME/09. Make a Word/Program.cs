using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace _09._Make_a_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string message = "";
            for(int i = 0;i < num; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += symbol.ToString();
            }
            Console.WriteLine($"The word is: {message}");
        }
    }
}
