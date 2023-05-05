using System;

namespace _05._Division_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            double p1Count = 0;
            double p2Count = 0;
            double p3Count = 0;
            for(int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1Count++;
                }
                if (number % 3 == 0)
                {
                    p2Count++;
                }
                if(number % 4 == 0)
                {
                    p3Count++;
                }
            }
            double p1 = p1Count / n * 100;
            double p2 = p2Count / n * 100;
            double p3 = p3Count / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
