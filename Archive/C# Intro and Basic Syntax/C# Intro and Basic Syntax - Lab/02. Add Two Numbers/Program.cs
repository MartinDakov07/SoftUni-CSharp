using System;

namespace _02._Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
    }
}
