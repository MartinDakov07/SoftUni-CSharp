using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            int maxNumber = int.MinValue;
            for(int i =1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if(num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            sum = sum - maxNumber;
            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sum)}");
            }
        }
    }
}
