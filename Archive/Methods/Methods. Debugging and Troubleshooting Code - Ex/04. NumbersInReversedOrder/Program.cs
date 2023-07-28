using System;
using System.Linq;

namespace _04._Numbers_in_Reversed_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversedNum = ReversedNumber(number.ToString());
            Console.WriteLine(reversedNum.ToString());
        }
        static string ReversedNumber(string number)
        {
            string reversedNumber = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            return reversedNumber;
        }
    }
}
