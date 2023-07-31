using System;

namespace _11._Geometry_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            FigureDetermination(figure);
        }
        static void FigureDetermination(string figure)
        {
            double area = 0;
            if(figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = TriangleArea(side, height);
            }
            else if(figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = SquareArea(side);
            }
            else if(figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = RectangleArea(width, height);
            }
            else if(figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = CircleArea(radius);
            }
            Console.WriteLine($"{area:f2}");
        }
        static double TriangleArea(double side, double height)
        {
            return side * height / 2;
        }
        static double SquareArea(double side)
        {
            return side * side;
        }
        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
        static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
