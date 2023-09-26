using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.IO;
namespace _04._Punctuation_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] lines = File.ReadAllLines(@"C:\Users\User\OneDrive\Documents\sample_text.txt");
            List<char> separators = new List<char>();
            char[] seps = new char[] { ',', '.', '?', '!', ':' };
            foreach(string line in lines)
            {
                for(int i = 0; i < line.Length; i++)
                {
                    if (seps.Contains(line[i]))
                    {
                        separators.Add(line[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",separators));
        }
    }
}
