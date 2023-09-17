using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _04._Distance_between_Points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] point1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] point2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int x1 = point1[0];
            int y1 = point1[1];
            int x2 = point2[0];
            int y2 = point2[1];

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);

            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"{distance:f3}");
        }
    }
    
}
