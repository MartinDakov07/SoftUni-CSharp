using System;

namespace _03._Last_K_Numbers_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long steps = long.Parse(Console.ReadLine());
            long[] sequence = new long[n];
            sequence[0] = 1;
            for(int i = 1; i < sequence.Length;i++)
            {
                long sum = 0;
                long last = i - 1;
                long ToSteps = 1;
                while(last >= 0 && ToSteps <= steps)
                {
                    sum += sequence[last--];
                    ToSteps++;
                }
                sequence[i] = sum;
            }
            for(int i = 0;i< sequence.Length; i++)
            {
                Console.Write(sequence[i] + " ");
            }
        }
    }
}
