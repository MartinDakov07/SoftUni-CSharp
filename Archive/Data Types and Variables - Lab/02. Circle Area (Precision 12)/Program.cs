using System;

namespace _02._Circle_Area__Precision_12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(Math.PI * r * r):f12}");
        }
    }
}
