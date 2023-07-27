using System;

namespace _02._Max_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int biggestNum = GetMax(a, b);
            Console.WriteLine(biggestNum);
        }
        static int GetMax(int a, int b)
        {
            int biggestNum = Math.Max(a, b);
            int c = int.Parse(Console.ReadLine());
            biggestNum = Math.Max(biggestNum, c);
            return biggestNum;
        }
    }
}
