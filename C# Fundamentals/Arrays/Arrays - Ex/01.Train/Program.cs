using System;
using System.Linq;
namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());

                sum += passengers[i];
                Console.Write($"{passengers[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{sum}");
            //int[] firstNumber = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToArray();
            //int result = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for(int i = 0; i < firstNumber.Length; i++)
            //{
            //    sum = 0;
            //    for(int j = i+ 1; j < firstNumber.Length; j++)
            //    {
            //        sum = firstNumber[i] + firstNumber[j];
            //        if(sum == result)
            //        {
            //            Console.WriteLine($"{firstNumber[i]} {firstNumber[j]}");
            //        }
            //        sum = 0;
            //    }
            //}










            //int n = int.Parse(Console.ReadLine());
            //
            //for(int i = 1; i <= n; i++)
            //{
            //    int firstNum = numbers[0];
            //    for (int j = 1; j < numbers.Length; j++)
            //    {
            //        numbers[j - 1] = numbers[j];
            //    }
            //    numbers[numbers.Length - 1] = firstNum;
            //}
            //Console.WriteLine(string.Join(" ",numbers));







        }
    }
}
