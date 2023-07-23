using System;

namespace _06._Calculate_Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = FindTriangleArea(width, height);
            Console.WriteLine($"{area}");
        }
        static double FindTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
