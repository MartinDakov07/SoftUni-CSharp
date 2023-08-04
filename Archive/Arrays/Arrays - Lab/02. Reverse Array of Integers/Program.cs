using System;

namespace _02._Reverse_Array_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for(int i = n - 1; i >= 0; i--)
            {
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
