using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bace = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaisePower(bace, power);
            Console.WriteLine(result);
        }
        static double RaisePower(int bace, int power)
        {
            double result = 1;
            result = Math.Pow(bace ,power);
            //for(int i = 1; i <= power; i++)
            //{
            //    result *= bace;
            //}
            return result;
        }
    }
}
