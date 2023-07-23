using System;

namespace _05._Temperature_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double farenhait = double.Parse(Console.ReadLine());
            double celsius = FarenhaitToCelsius(farenhait);
            Console.WriteLine($"{celsius:f2}");
        }
        static double FarenhaitToCelsius(double farenhait)
        {
            return (farenhait - 32) * 5 / 9;
        }
    }
}
