using System;

namespace _01._Debit_Card_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            Console.Write($"{num1:D4} ");
            Console.Write($"{num2:D4} ");
            Console.Write($"{num3:D4} ");
            Console.Write($"{num4:D4} ");
        }
    }
}
