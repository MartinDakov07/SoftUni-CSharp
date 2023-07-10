using System;

namespace _07._Exchange_Variable_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNum}");
            Console.WriteLine($"b = {secondNum}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {secondNum}");
            Console.WriteLine($"b = {firstNum}");
        }
    }
}
