using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _05._Short_Words_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            List<string> words = input.Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '/', '\\', '!', '?', ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(string.Join(", ",words.Where(x=>x.Length < 5).OrderBy(x=>x).Distinct()));

        }
    }
}
