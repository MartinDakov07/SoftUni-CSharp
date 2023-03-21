using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            Console.Write("Length: ");

            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

           double widht = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            double height = double.Parse(Console.ReadLine());
            double V = 0;
            V = (length + widht + height)/3;

            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}
