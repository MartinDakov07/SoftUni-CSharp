using System;

namespace _08._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            (double pointX, double pointY) = GetBestCoordinates(x1, y1, x2, y2);
            Console.WriteLine($"({pointX}, {pointY})");

        }
        static double GetSquaredCoordinate(double x, double y)
        {
            return Math.Abs(x * x + y * y);
        }
        static (double,double) GetBestCoordinates(double x1, double y1, double x2, double y2)
        {
            double firstCoordinates = GetSquaredCoordinate(x1, y1);
            double secondCoordinates = GetSquaredCoordinate(x2, y2);
            return firstCoordinates <= secondCoordinates ? (x1, y1) : (x2, y2);
        }
    }
}
