using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowelsCount = GetVowelsFromWord(word);
            Console.WriteLine(vowelsCount);
        }
        static int GetVowelsFromWord(string word)
        {
            int vowelsCount = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == 'a' || word[i] == 'e'|| word[i] == 'i'|| word[i] == 'o'|| word[i] == 'u'
                    ||word[i] == 'A' || word[i] == 'E' ||
                    word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
