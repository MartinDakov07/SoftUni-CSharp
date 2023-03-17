using System;

namespace _10._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {

                    Console.WriteLine($"{integer} X {i} = {integer * i}");
                }
            }
            else if(multiplier > 10)
            {
                Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier}");
            }
            
        }
    }
}
