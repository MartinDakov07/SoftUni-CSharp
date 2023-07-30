using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace _07._Primes_in_Given_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> numbers = GetPrimeNums(startNum, endNum);
            Console.WriteLine(string.Join(", ",numbers));
        }
        static List<int> GetPrimeNums(int startNum, int endNum)
        {
            List<int> numbers = new List<int>();
            for(int i = startNum;i <= endNum; i++)
            {
                if (i == 1 || i == 0)
                {
                    continue;
                }
                int count = 0;
                for(int j = 1;j <= i; j++)
                {                   
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }
    }
}
