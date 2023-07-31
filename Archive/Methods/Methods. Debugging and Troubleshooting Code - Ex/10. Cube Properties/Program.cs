using System;

namespace _10._Cube_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();
            double result = 0;
            if(parameter == "face")
            {
                result = FaceOfCube(side);
            }
            else if(parameter == "space")
            {
                result = SpaceDiagonalOfCube(side);
            }
            else if(parameter == "volume")
            {
                result = VolumeOfCube(side);
            }
            else if(parameter == "area")
            {
                result = AreaOfCube(side);
            }
            Console.WriteLine($"{result:f2}");
        }
        static double FaceOfCube(double side)
        {
            double face = Math.Sqrt(2) * side;
            return face;
        }
        static double SpaceDiagonalOfCube(double side)
        {
            double space = Math.Sqrt(3) * side;
            return space;
        }
        static double VolumeOfCube(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }
        static double AreaOfCube(double side)
        {
            double area = Math.Pow(side,2) * 6;
            return area;
        }
    }
}
