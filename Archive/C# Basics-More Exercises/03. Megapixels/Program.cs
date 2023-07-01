using System;

namespace _03._Megapixels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal width = int.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal mp = Math.Round((width * height / 1_000_000), 1);                         
            Console.WriteLine($"{width}x{height} => {mp}MP");                                                             
        }            
    }
}
