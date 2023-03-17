using System;

namespace _08._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int oddNum = 1;
            for (int i = 1; i <= num; i++)
            {
                
                Console.WriteLine($"{oddNum}");
                oddSum += oddNum;
                oddNum += 2;
            }
            Console.WriteLine($"Sum: {oddSum}");
        }
    }
}
