using System;

namespace _12._Rectangle_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + height * 2;
            double area = width * height;
            double doubleWidth = Math.Pow(width, 2);
            double doubleHeight = Math.Pow(height, 2);
            double diagonal = Math.Sqrt(doubleWidth + doubleHeight);           
            Console.WriteLine($"{perimeter}");
            Console.WriteLine($"{area}");
            Console.WriteLine($"{diagonal}");
        }
    }
}
