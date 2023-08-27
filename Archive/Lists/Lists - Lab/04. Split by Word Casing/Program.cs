using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
namespace _04._Split_by_Word_Casing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ',', ';', '.', ':', '!', '(', ')', '\"', '\'', '/', '\\', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowCase = new List<string>();
            List<string> upCase = new List<string>();
            List<string> mixCase = new List<string>();
            int lowChar = 0;
            int upChar = 0;
            foreach(string word in words)
            {
                AnalyzeTheWord(word, upChar, lowChar, lowCase, upCase, mixCase);
            }
            Console.WriteLine($"Lower-case: {string.Join(", ",lowCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",mixCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upCase)}");
        }
        static void AnalyzeTheWord(string word,int up, int low,List<string> lowCase,List<string> upCase,List<string> mix)
        {           
            foreach(char c in word)
            {
                if (char.IsUpper(c))
                {
                    up++;
                }
                else if(char.IsLower(c))
                {
                    low++;
                }
            }
            if (up == word.Length)
            {
                upCase.Add(word);
            }
            else if(low == word.Length)
            {
                lowCase.Add(word);
            }
            else
            {
                mix.Add(word);
            }
        }
    }
}
