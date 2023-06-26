using System;

namespace _06._Interval_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int biggerNum = firstNum < secondNum ? secondNum : firstNum;
            int smallerNum = firstNum > secondNum ? secondNum : firstNum;
            for(int i = smallerNum; i <= biggerNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
