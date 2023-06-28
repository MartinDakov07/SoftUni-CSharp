using System;

namespace _12._Test_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxBoundary = int.Parse(Console.ReadLine());
            int count = 0;
            int total = 0;
            for(int i = num1; i >= 1; i--)
            {
                for(int j = 1; j <= num2; j++)
                {
                    total += 3 * i * j;
                    count++;
                    if (total >= maxBoundary)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {total} >= {maxBoundary}");
                        return;
                    }
                }
                
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {total} ");
        }
    }
}
