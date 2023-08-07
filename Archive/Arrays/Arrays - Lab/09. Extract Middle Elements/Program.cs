using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            if(numbers.Length == 1)
            {
                Console.Write("{");
                Console.Write($" {numbers[0]} ");
                Console.Write("}");
                return;
            }
            else if(numbers.Length % 2 == 0)
            {
                int[] evenArr = new int[2];
                evenArr[0] = numbers[numbers.Length / 2 - 1];
                evenArr[1] = numbers[numbers.Length / 2];
                Console.Write("{");
                Console.Write($" {evenArr[0]}, ");
                Console.Write($" {evenArr[1]} ");
                Console.Write("}");
            }
            else if(numbers.Length % 2 != 0)
            {
                int[] oddArr = new int[3];
                oddArr[0] = numbers[numbers.Length / 2 - 1];
                oddArr[1] = numbers[numbers.Length / 2];
                oddArr[2] = numbers[numbers.Length / 2 + 1];
                Console.Write("{");
                Console.Write($" {oddArr[0]}, ");
                Console.Write($" {oddArr[1]}, ");
                Console.Write($" {oddArr[2]} ");
                Console.Write("}");
            }
        }
    }
}
