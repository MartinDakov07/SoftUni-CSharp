using System;

namespace FirstStepsInCoding
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Making from USD to BGN
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);

        }
    }
}
