using System;

namespace _03._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterTank = 255;
            int n = int.Parse(Console.ReadLine());
            int yourTank = 0;
            for(int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if(quantity > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTank -= quantity;
                    yourTank += quantity;
                }
            }
            Console.WriteLine(yourTank);
        }
    }
}
