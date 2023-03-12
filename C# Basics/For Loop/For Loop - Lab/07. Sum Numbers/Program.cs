using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNums = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            for(int counter = 0; counter <countOfNums; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumOfNumbers += currentNumber;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
