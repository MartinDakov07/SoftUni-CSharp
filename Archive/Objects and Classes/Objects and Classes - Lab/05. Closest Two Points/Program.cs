﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _05._Closest_Two_Points
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints(); //•	Create an array Point[] points that will keep all points.
            Point[] closest2Points = FindClosestTwoPoints(points);
            Console.WriteLine("{0:F3}", CalculateDistance(closest2Points[0], closest2Points[1]));
            Printpoint(closest2Points[0]);
            Printpoint(closest2Points[1]);
        }

        private static void Printpoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int i1 = 0; i1 < points.Length; i1++)
            {
                for (int i2 = i1 + 1; i2 < points.Length; i2++)
                {
                    double distance = CalculateDistance(points[i1], points[i2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[i1], points[i2] };
                    }
                }
            }
            return closestTwoPoints;
        }
        private static double CalculateDistance(Point point1, Point point2)
        {
            double sideA = point1.X - point2.X;
            double sideB = point1.Y - point2.Y;
            double distan = Math.Sqrt(Math.Pow(sideA,2) + Math.Pow(sideB,2));
            return distan;
        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        private static Point ReadPoint()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p = new Point() { X = array[0], Y = array[1] };
            return p;
        }
    }
//This solution is from the internet (just right the problem name - softuni)
}
