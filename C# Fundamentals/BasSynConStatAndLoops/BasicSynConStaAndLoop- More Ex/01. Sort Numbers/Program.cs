//Create a program that receives three real numbers and sorts them in descending order.
//Print each number on a new line.
using System;
namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int highest = Math.Max(Math.Max(num1, num2), Math.Max(num2, num3));
            int lowest = Math.Min(Math.Min(num1, num2), Math.Min(num2, num3));
            int average = num1 + num2 + num3 - lowest - highest;
            Console.WriteLine(highest);
            Console.WriteLine(average);
            Console.WriteLine(lowest);
           
        }
    }
}
