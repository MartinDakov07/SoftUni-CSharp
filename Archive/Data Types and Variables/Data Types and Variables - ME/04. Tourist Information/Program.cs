using System;

namespace _04._Tourist_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imperial = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (imperial)
            {
                case "miles":
                    Console.WriteLine($"{quantity} miles = {(quantity*1.6):f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{quantity} inches = {(quantity * 2.54):f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{quantity} feet = {(quantity * 30):f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{quantity} yards = {(quantity * 0.91):f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{quantity} gallons = {(quantity * 3.8):f2} liters");
                    break;
            }
        }
    }
}
