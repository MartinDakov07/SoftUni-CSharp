using System.Collections.Generic;
using System;
using System.Numerics;
namespace leetcode
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string ransomNote = Console.ReadLine();
            string magazine = Console.ReadLine();
            bool canConstruct = CanConstruct(ransomNote, magazine);
        }
        static public bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> letters = new List<char>();
            for (int i = 0; i < magazine.Length; i++)
            {
                letters.Add(magazine[i]);
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (letters.Contains(ransomNote[i]))
                {
                    letters.Remove(ransomNote[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

    }
}
