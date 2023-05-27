using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestDna = new int[n];
            
            int counter = 0;
            int bestIndex = 0;
            int bestLength = 0;
            int bestSum = 0;
            int bestCounter = 0;
            string input = Console.ReadLine();
            
            while(input != "Clone them!")
            {
                counter++;
                int[] currArr = new int[n];
                currArr = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentIndex = 0;
                int currentLeng = 0;
                int currentSum = currArr[n - 1];
                int index = 0;
                int leng = 0;

                for (int i = 0; i < n - 1; i++)
                {
                    currentSum += currArr[i];
                    if (currArr[i] == currArr[i + 1])
                    {
                        if (leng == 0) index = i;
                        leng++;
                    }
                    else
                    {
                        leng = 0;
                    }

                    if (leng > currentLeng)
                    {
                        currentLeng = leng;
                        currentIndex = index;
                    }
                }

                if ((currentLeng > bestLength) ||
                    (currentLeng == bestLength && currentIndex < bestIndex) ||
                    (currentLeng == bestLength && currentIndex == bestIndex && currentSum > bestSum))
                {
                    bestDna = currArr;
                    bestLength = currentLeng;
                    bestIndex = currentIndex;
                    bestSum = currentSum;
                    bestCounter = counter;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ",bestDna));
        }
    }
}
