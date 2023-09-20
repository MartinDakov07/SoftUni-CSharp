using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Drawing;

namespace _03._Circles_Intersection
{
    internal class Program
    {
        class Circle
        {
            public int CenterPointX { get; set; }
            public int CenterPointY { get; set; }
            public int Radius { get; set; }
            
            class Point
            {
                public int X { get; set; }
                public int Y { get; set; }
            }
        }

        static bool IsIntersect()
        {
            int[] firstCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point r1 = new Point() { X = firstCircle[0], Y = firstCircle[1] };
            Point r2 = new Point() { X = secondCircle[0], Y = secondCircle[1] };

            int firstRadius = firstCircle[2];
            int secondRadius = secondCircle[2];

            Circle alpha = new Circle() { CenterPointX = r1.X, CenterPointY = r1.Y, Radius = firstRadius };
            Circle beta = new Circle() { CenterPointX = r2.X, CenterPointY = r2.Y, Radius = secondRadius };

            double sum = alpha.Radius + beta.Radius;

            double distance = Math.Sqrt(Math.Pow(alpha.CenterPointX - beta.CenterPointX, 2) + Math.Pow(alpha.CenterPointY - beta.CenterPointY, 2));
            
            if(distance > sum)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            if (IsIntersect())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
