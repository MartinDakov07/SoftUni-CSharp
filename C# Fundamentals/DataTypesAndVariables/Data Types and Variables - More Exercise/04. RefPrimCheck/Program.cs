using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool IsPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, IsPrime);
            }

        }
    }
}
