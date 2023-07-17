using System;

namespace _06._Catch_the_Thief
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numerType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());           
            long value = 0;
            long closest = 0;
            if (numerType == "sbyte")
            {
                value = sbyte.MaxValue;
                closest = sbyte.MinValue;
            }
            else if(numerType == "int")
            {
                value = int.MaxValue;
                closest = int.MinValue;
            }
            else if(numerType == "long")
            {
                value = long.MaxValue;
                closest = long.MinValue;
            }           
            for (int i = 0; i< n; i++)
            {
                long num = long.Parse(Console.ReadLine());
                if(num <= value)
                {
                    if(num > closest)
                    {
                        closest = num;
                    }                   
                }
            }
            Console.WriteLine(closest);
        }
    }
}
