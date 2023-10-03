using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;
using System.Text;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01._Convert_from_base_10_to_base_N
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            List<BigInteger> numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            int n = (int)numbers[0];
            BigInteger num = numbers[1];
            BigInteger remainder;
            string result = null;
            if(n>=2 && n <= 10)
            {
                while(num > 0)
                {
                    remainder = num % n;
                    num /= n;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
