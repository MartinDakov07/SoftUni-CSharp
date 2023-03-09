using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string assesor = string.Empty;
            double assesorPoints = 0;
            for (int i = 1; i <=n; i++)
            {
                assesor = Console.ReadLine();
                assesorPoints = double.Parse(Console.ReadLine());
                points += assesor.Length * assesorPoints / 2;
                if (points >= 1250.5)
                {
                    break;
                }
            }
            //"Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
            if (points >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
            }
            // "Sorry, {име на актьора} you need {нужни точки} more!"
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5 - points):f1} more!");
            }
        }
    }
}
