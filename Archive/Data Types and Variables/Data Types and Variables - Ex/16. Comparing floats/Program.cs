using System;

namespace _16._Comparing_floats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal bigger = firstNum > secondNum ? firstNum : secondNum;
            decimal smaller = firstNum < secondNum ? firstNum : secondNum;
            if(bigger - smaller < 0.000001m)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
