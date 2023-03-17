using System;

namespace _09._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{multiplier} X {i} = {multiplier * i}");
            }
        }
    }
}
