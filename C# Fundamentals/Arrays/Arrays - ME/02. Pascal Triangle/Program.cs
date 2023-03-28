using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n + 1];
            int[] oldArray = new int[n + 1];
            newArray[1] = 1;
            Console.WriteLine(newArray[1]);
            for(int rows = 1; rows < n; rows++)
            {
                for (int i = 1; i <= n; i++) oldArray[i] = newArray[i];
                
                for(int i = 1; i <= rows + 1; i++)
                {
                    newArray[i] = oldArray[i - 1] + oldArray[i];
                    Console.Write(newArray[i] + " ");
                }
                Console.WriteLine();                
            }
        }
    }
}
