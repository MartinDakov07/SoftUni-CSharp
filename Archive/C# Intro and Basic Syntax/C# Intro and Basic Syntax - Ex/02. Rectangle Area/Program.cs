using System;

namespace _02._Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(num1*num2):f2}");
        }
    }
}
