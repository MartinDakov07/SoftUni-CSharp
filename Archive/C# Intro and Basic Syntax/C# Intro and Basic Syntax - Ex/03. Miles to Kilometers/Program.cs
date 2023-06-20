using System;

namespace _03._Miles_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine()) * 1.60934;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
