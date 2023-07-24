using System;

namespace _07._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = FindPower(num, power);
            Console.WriteLine(result);
        }
        static double FindPower(double n, double power)
        {            
            return Math.Pow(n, power);
        }
    }
}
