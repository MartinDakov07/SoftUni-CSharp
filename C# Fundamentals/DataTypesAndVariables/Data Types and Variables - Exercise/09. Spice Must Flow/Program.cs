using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYields = int.Parse(Console.ReadLine());
            int leftSpices = 0;
            int daysCount = 0;
            if(startYields >= 100)
            {
                while (startYields >= 100)
                {
                    leftSpices += startYields - 26;
                    if(leftSpices < 26)
                    {
                        leftSpices += 0;
                    }
                    daysCount++;
                    startYields -= 10;
                }
                if (startYields < 100)
                {
                    leftSpices -= 26;
                }
                Console.WriteLine($"{daysCount}");
                Console.WriteLine($"{leftSpices}");
            }
            else
            {
                Console.WriteLine($"{daysCount}");
                Console.WriteLine($"{leftSpices}");
            }
            

        }
    }
}
