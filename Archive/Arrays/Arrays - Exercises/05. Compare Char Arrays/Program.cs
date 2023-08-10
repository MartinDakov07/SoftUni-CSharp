using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] firstInput = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
            char[] secondInput = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
            string[] concatenatedChars = new string[2];
            int shorterString = Math.Min(firstInput.Length, secondInput.Length);
            int longerString = Math.Max(firstInput.Length, secondInput.Length);
            if(shorterString == longerString)
            {
                EqualLengths(longerString, concatenatedChars, firstInput, secondInput);
            }
            else
            {
                DifferentLengths(shorterString, longerString, concatenatedChars, firstInput, secondInput);
            }
            
        }
        static void EqualLengths(int length, string[] words, char[] first, char[] second)
        {
            for (int i = 0; i < length; i++)
            {
                words[0] += first[i];
                words[1] += second[i];
            }
            foreach (var word in words.OrderBy(x => x[0]))
            {
                Console.WriteLine(words);
            }
        }
        static void DifferentLengths(int shortLength, int longerString, string[] words, char[] first, char[] second)
        {
            for (int i = 0; i < shortLength; i++)
            {
                if (first.Length > second.Length)
                {
                    words[0] += second[i];
                }
                else
                {
                    words[0] += first[i];
                }
            }
            for (int j = 0; j < longerString; j++)
            {
                if (first.Length > second.Length)
                {
                    words[1] += first[j];
                }
                else
                {
                    words[1] += second[j];
                }
            }
            foreach (var word in words.OrderBy(x => x[0]))
            {
                Console.WriteLine(word);
            }
        }
    }
}
