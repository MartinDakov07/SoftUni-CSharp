using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result = GetResultFromDivide(firstNum, secondNum);
            Console.WriteLine($"{result:f2}");
        }
        static double GetResultFromDivide(int firstNum, int secondNum)
        {
            double firstFactoriel = 1;
            double secondFactoriel = 1;
            double result = 0;  
            for(int i = firstNum; i >= 1; i--)
            {
                firstFactoriel *= i;
            }
            for(int j = secondNum; j >= 1; j--)
            {
                secondFactoriel *= j;
            }
            result = firstFactoriel / secondFactoriel;
            return result;
        }
    }
}
