using System;

namespace _04._Photo_Gallery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string type = "";
            Console.WriteLine($"Name: DSC_{name:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d2} {hours:d2}:{mins:d2}");
            if (size < 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if(size >= 1000 && size <= 1000000)
            {
                Console.WriteLine($"Size: {size/1000}KB");
            }
            else if(size>=1000000)
            {
                Console.WriteLine($"Size: {size/1000000}MB");
            }
            
            if(width > height)
            {
                type = "landscape";
            }
            else if(height > width)
            {
                type = "portrait";
            }
            else if(width == height)
            {
                type = "square"; 
            }
            Console.WriteLine($"Resolution: {width}x{height} ({type})");
        }
    }
}
