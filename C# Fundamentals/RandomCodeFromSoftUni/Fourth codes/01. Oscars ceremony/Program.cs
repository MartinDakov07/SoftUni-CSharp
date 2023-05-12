using System;

namespace _01._Oscars_ceremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double statues = rent - rent * 0.3;
            double ketyring = statues - statues * 0.15;
            double sound = ketyring / 2;
            double totalPrice = rent + statues + ketyring + sound;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
