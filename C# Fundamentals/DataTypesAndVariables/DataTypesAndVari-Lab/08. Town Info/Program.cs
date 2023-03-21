using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            ushort km = ushort.Parse(Console.ReadLine());
            Console.WriteLine($"Town {name} has population of {population} and area {km} square km.");
        }
    }
}
