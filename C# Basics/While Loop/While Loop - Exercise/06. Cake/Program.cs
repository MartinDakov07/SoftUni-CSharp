using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int cakeSize = widht * lenght;
            int cakePieces = 0;
            string input = Console.ReadLine();
            while (input != "STOP")
            {
                cakePieces = int.Parse(input);
                if(cakeSize>= cakePieces)
                {
                    cakeSize -= cakePieces;
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize - cakePieces)} pieces more.");
                        break;
                }
                
                
                input = Console.ReadLine();
            }
            if(input == "STOP")
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
