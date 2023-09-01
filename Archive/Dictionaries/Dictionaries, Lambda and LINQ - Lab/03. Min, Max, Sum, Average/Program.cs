using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace _03._Min__Max__Sum__Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for(int i = 0; i < numbers.Length; i++)
            {
                double num = double.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            double average = numbers.Sum() / numbers.Length;
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
