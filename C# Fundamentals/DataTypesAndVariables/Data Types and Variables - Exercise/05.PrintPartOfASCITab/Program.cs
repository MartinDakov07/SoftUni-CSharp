using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int finalIndex = int.Parse(Console.ReadLine());
            for(int i = startIndex; i <= finalIndex; i++)
            {
                char symbol = (char)i;
                Console.Write($"{symbol} ");
            }


        }
    }
}
