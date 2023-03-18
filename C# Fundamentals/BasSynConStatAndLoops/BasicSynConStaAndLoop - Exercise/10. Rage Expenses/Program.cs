using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());           
            int brokenHeadsets = 0;
            int brokenMouses = 0;
            int brokenKeyboards = 0;
            int brokenDisplays = 0;
            double totalPrice = 0;
            for(int i = 1; i <= lostGamesCount; i++)
            {
                if(i % 2 == 0)
                {
                    brokenHeadsets++;
                }
                if(i % 3 == 0)
                {
                    brokenMouses++;
                }
                if (i % 6 == 0)
                {
                    brokenKeyboards++;
                }
                if (i % 12 == 0)
                {
                    brokenDisplays++;
                }
            }
            double headsetTotal = headsetPrice * brokenHeadsets;
            double mouseTotal = mousePrice * brokenMouses;
            double keyboardTotal = keyboardPrice * brokenKeyboards;
            double displayTotal = displayPrice * brokenDisplays;
            totalPrice = headsetTotal + mouseTotal + keyboardTotal + displayTotal;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");

        }
    }
}
