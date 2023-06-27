using System;

namespace _09._Count_the_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int count = 0;
            while (true)
            {
                try
                {
                    int number = int.Parse(num);
                    count++;
                }
                catch
                {
                    break;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(count);
        }
    }
}
