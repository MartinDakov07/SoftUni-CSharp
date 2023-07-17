using System;

namespace _07._Sentence_the_Thief
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double value = 0;
            double closest = 0;
            if (numType == "sbyte")
            {
                value = sbyte.MaxValue;
                closest = sbyte.MinValue;
            }
            else if (numType == "int")
            {
                value = int.MaxValue;
                closest = int.MinValue;
            }
            else if (numType == "long")
            {
                value = long.MaxValue;
                closest = long.MinValue;
            }
            for(int i = 0; i < n; i++)
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
            double prisonDays = 0;
            if(closest < 0)
            {
                prisonDays = (double)(closest / sbyte.MinValue);
            }
            else
            {
                prisonDays = (double)(closest / sbyte.MaxValue);
            }

            prisonDays = Math.Ceiling(prisonDays);

            if(prisonDays == 1)
            {
                Console.WriteLine($"Prisoner with id {closest} is sentenced to {prisonDays} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {closest} is sentenced to {prisonDays} years");
            }
        }
    }
}
