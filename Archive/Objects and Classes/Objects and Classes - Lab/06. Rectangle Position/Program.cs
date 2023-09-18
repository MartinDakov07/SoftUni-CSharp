using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _06._Rectangle_Position
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstRect = ReadRectangle();
            var secondRect = ReadRectangle();
            var result = firstRect.Isinside(secondRect);
            //    var printResult = result ? "Inside" : "Not inside";
            if (result)

            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");

            }
        }
        //  Console.WriteLine(result);

        public class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Right
            {
                get
                {
                    return Left + Width;
                }

            }
            public bool Isinside(Rectangle rectangle)
            {
                var leftIsValid = rectangle.Left <= Left;
                var topIsValid = rectangle.Top <= Top;
                var rightIsValid = rectangle.Right >= Right;
                var bottomIsValid = rectangle.Bottom >= Bottom;
                return
                    leftIsValid && topIsValid && rightIsValid && bottomIsValid;
            }
        }
        public static Rectangle ReadRectangle()
        {
            var rectangleParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}

