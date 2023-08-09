using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace _04._Sieve_of_Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            { 
                isPrime[i] = true; 
            }
            isPrime[0] = false; isPrime[1] = false;
            for (int i = 0; i < n + 1; i++)
            {
                if (isPrime[i])
                {
                    for (int j = 2; (j * i) <= n; j++)//everytime we find a prime number, all the numbers after it multiplied by 2,3,4 etc are not prime
                    { 
                        isPrime[j * i] = false; 
                    }
                }
            }
            for (int j = 2; j <= n; j++)
            {
                if (isPrime[j] == true) { Console.Write(j + " "); }
            }
            Console.WriteLine();
        }
    }
}
