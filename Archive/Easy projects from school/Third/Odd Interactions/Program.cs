using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Nechetni_Sreshtaniq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> lines = new Dictionary<string, int>();
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);               
            for(int i = 0; i < input.Length; i++)
            {
                string lowerWord = input[i].ToLower();
                if (!lines.ContainsKey(lowerWord))
                {
                    lines.Add(lowerWord, 1);
                }
                else
                {
                    lines[lowerWord]++;
                }
            }
            Console.WriteLine(string.Join(", ",lines.Where(l=>l.Value % 2 !=0).Select(x=>x.Key)));
        }
    }
}
