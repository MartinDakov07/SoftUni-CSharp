using System;
using System.Numerics;//This will activate BigInteger variable
namespace _08._House_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            sbyte byteNum = 0;
            BigInteger intNum = 0;
            try
            {
                byteNum = sbyte.Parse(num1);
            }
            catch
            {
                intNum = BigInteger.Parse(num1);
            }
            try
            {
                byteNum = sbyte.Parse(num2);
            }
            catch
            {
                intNum = BigInteger.Parse(num2);
            }
            
            BigInteger totalCost = (4 * byteNum) + (10 * intNum);
            Console.WriteLine(totalCost);
        }
    }
}
