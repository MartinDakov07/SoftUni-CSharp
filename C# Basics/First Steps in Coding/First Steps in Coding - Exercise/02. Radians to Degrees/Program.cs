using System;

namespace _02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Preobrazuvane ot radiani kym gradusi
            double radians = double.Parse(Console.ReadLine());
            // Formula za gradusi градус = радиан * 180 / π
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(degrees);

        }
    }
}
