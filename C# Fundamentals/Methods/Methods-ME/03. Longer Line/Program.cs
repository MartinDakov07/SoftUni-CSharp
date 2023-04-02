using System;

namespace _03._Longer_Line
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

            GetLongerLine(firstX1,firstY1,firstX2,firstY2,secondX1,secondY1,secondX2,secondY2);
        }
        static double DistancePointOne(double firstX1, double firstY1, double basePointX, double basePointY)
        {
            double result1 = (basePointX - firstX1) * (basePointY - firstX1) + (basePointX - firstY1) * (basePointY - firstY1);

            return result1;
        }
        static double DistancePointTwo(double firstX2, double firstY2, double basePointX, double basePointY)
        {
            double result2 = (basePointX - firstX2) * (basePointY - firstX2) + (basePointX - firstY2) * (basePointY - firstY2);

            return result2;
        }
        static void GetLongerLine(double firstX1, double firstY1, double firstX2, double firstY2, double secondX1, double secondY1, double secondX2, double secondY2)
        {
            double basePointX = 0;
            double basePointY = 0;
            double longerResult1 = ((firstX1 - firstX2) * (firstX1 - firstX2) + (firstY1 - firstY2) * (firstY1 - firstY2));
            double longerResult2 = ((secondX1 - secondX2) * (secondX1 - secondX2) + (secondY1 - secondY2) * (secondY1 - secondY2));
            if (longerResult1 >= longerResult2)
            {
                double result1 = DistancePointOne(firstX1, firstY1, basePointX, basePointY);
                double result2 = DistancePointOne(firstX2, firstY2, basePointX, basePointY);
                if(result1 <= result2)
                {
                    Console.WriteLine($"({firstX1}, {firstY1})({firstX2}, {firstY2})");
                }
                else
                {
                    Console.WriteLine($"({firstX2}, {firstY2})({firstX1}, {firstY1})");
                }
            }
            else
            {
                double result1 = DistancePointOne(secondX1, secondY1, basePointX, basePointY);
                double result2 = DistancePointOne(secondX2, secondY2, basePointX, basePointY);
                if (result1 <= result2)
                {
                    Console.WriteLine($"({secondX1}, {secondY1})({secondX2}, {secondY2})");
                }
                else
                {
                    Console.WriteLine($"({secondX2}, {secondY2})({secondX1}, {secondY1})");
                }
            }
        }
    }
}
