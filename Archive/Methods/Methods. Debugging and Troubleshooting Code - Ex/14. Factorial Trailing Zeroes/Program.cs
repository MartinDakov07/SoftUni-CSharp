using System;
using System.Drawing;
using System.Numerics;
namespace _14._Factorial_Trailing_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            ReturnTrailingZeroesCount(sum, count);
        }
        static void ReturnTrailingZeroesCount(BigInteger sum,int count)
        {
            while (sum > 0)
            {
                var rem = sum % 10;
                if (rem == 0)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }
                sum /= 10;
            }
        }
    }
}
