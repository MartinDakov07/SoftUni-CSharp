using System;

namespace _05._Weather_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                sbyte sunny = sbyte.Parse(number);
                Console.WriteLine("Sunny");
                return;
            }
            catch
            {

            }

            try
            {
                int cloudy = int.Parse(number);
                Console.WriteLine("Cloudy");
                return;
            }
            catch
            {

            }

            try
            {
                long windy = long.Parse(number);
                Console.WriteLine("Windy");
                return;
            }
            catch
            {

            }
            if (double.Parse(number) % 1 != 0)
            {
                Console.WriteLine("Rainy");
                return;
            }
        }
    }
}
