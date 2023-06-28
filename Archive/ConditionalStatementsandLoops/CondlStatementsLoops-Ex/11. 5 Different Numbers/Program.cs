using System;
using System.Collections.Generic;

namespace _11._5_Different_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int firstNum = int.Parse(Console.ReadLine());
             int secondNum = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    for (int k = firstNum; k <= secondNum; k++)
                    {
                        for (int l = firstNum; l <= secondNum; l++)
                        {
                            for (int m = firstNum; m <= secondNum; m++)
                            {
                                if(firstNum <= i && i < j && j < k && k < l && l < m && m <= secondNum)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    count++;
                                }
                            }
                        }
                    }
                }
                if(count == 0)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
       }
    }
}
