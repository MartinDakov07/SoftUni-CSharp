using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.Write("0");
            }
            else if(num == 1)
            {
                Console.Write("1");
            }
            else if(num == 2)
            {
                Console.Write("1 1");
            }
            else if(num == 3)
            {
                Console.Write("1 1 2");
            }
            else
            {
                Console.Write("1 1 2 ");
                GetTribonacci(num);
            }
        }
        static void GetTribonacci(int num)
        {
            int a = 1;
            int b = 1;
            int c = 2;

            int result = num;
            for(int i = 0; i < num - 3; i++)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
                Console.Write($"{c} ");
            }
            
        }
    }
}
