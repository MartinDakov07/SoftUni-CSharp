using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int smallestNum = GetSmallestNum(a, b, c);
            Console.WriteLine(smallestNum);
        }
        static int GetSmallestNum(int a , int b , int c)
        {
            int smallestNum = 0;
            if (a < b && a < c)
            {
                smallestNum = a;
            }
            else if (b < a && b < c)
            {
                smallestNum = b;
            }
            else 
            {
                smallestNum = c;
            }
            return smallestNum;
        }
    }
}
