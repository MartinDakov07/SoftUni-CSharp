using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число -дължина на страната му

           //Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа -дължините на страните му

           //Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга

           // Ако фигурата е триъгълник(triangle): на следващите два реда четат две дробни числа -дължината на страната му и дължината на височината към нея
            string typeOfFigure = Console.ReadLine();
            if (typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double result = side * side;
                Console.WriteLine($"{result:f3}");
            }
            else if (typeOfFigure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double result = side1 * side2;
                Console.WriteLine($"{result:f3}");
            }
            else if (typeOfFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = radius * radius * Math.PI;
                Console.WriteLine($"{result:f3}");
            }
            else if (typeOfFigure == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());
                double result = sideOfTriangle * heightOfTriangle / 2;
                Console.WriteLine($"{result:f3}");
            }
        }
    }
}
