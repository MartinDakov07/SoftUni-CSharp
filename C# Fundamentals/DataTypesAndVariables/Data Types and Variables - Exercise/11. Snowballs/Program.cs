using System;
using System.Numerics;
namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            
            
            BigInteger snowballBestValue = BigInteger.MinusOne;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;
            for(int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);
                if(snowballValue > snowballBestValue)
                {
                    snowballBestValue = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {snowballBestValue} ({ maxQuality})");
        }
    }
}
