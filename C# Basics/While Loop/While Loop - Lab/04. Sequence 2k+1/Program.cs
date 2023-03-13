using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input = 0;
            while (n >= input)
            {
               
                input = input * 2 + 1;
                if(input <= n)
                {
                    Console.WriteLine(input);
                }
                
            }
        }
    }
}
