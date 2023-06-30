using System;

namespace _01._X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || j == n - i -1)
                        Console.Write("x");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
