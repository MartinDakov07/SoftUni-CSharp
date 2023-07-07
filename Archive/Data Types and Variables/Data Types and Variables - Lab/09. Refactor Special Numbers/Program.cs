using System;

namespace _09._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; 
            int copyNum = 0;
            bool isTrue = false;
            for (int i = 1; i <= n; i++)
            {
                copyNum = i;
                sum = 0;
                while (copyNum > 0)
                {
                    sum += copyNum % 10;
                    copyNum = copyNum / 10;
                }
                
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);               
                Console.WriteLine($"{i} -> {isTrue}");                                
            }

        }
    }
}
