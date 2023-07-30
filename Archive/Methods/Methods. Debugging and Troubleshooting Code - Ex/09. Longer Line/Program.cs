using System;

namespace _09._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());

            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());

            double resultX1, resultY1, resultX2, resultY2;

            if (GetLineLength(firstX1, firstY1, firstX2, firstY2) >= GetLineLength(secondX1, secondY1, secondX2, secondY2))
            {
                (resultX1, resultY1, resultX2, resultY2) = CloserCoordinates(firstX1, firstY1, firstX2, firstY2);
            }
            else
            {
                (resultX1, resultY1, resultX2, resultY2) = CloserCoordinates(secondX1, secondY1, secondX2, secondY2);
            }
            Console.WriteLine($"({resultX1}, {resultY1})({resultX2}, {resultY2})");

        }
        static double GetDistance(double x, double y)
        {
            return (x * x) + (y * y); //You can use Math.Sqrt(x,2) + Math.Sqrt(y,2) - its the same
        }
        static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            return (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1); // If you ask yourself how you find it like that - its just the formula, you can check in google
        }
        static (double, double, double, double) CloserCoordinates(double x1, double y1, double x2, double y2)
        {
            double firstDistane = GetDistance(x1, y1);
            double secondDistance = GetDistance(x2, y2);
            return firstDistane <= secondDistance ? (x1, y1, x2, y2) : (x2, y2, x1, y1);
        }
    }
}
