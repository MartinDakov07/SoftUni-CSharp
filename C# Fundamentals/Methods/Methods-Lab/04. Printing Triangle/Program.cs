using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                PrintLine(i);
            }
            for(int i = num - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
        static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
