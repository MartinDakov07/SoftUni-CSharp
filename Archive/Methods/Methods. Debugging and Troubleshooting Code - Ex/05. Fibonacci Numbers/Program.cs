using System;

namespace _05._Fibonacci_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetFibbonaciNum(number);
        }
        static void GetFibbonaciNum(int number)
        {
            int n1=0, n2=1, n3;
            if(number == 0)
            {
                Console.WriteLine(1);
                return;
            }
            for(int i = 1; i <= number; i++)
            {
                n3 = n1 + n2;
                if(i == number)
                {
                    Console.Write($"{n3}");
                }                
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
