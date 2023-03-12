using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int length = word.Length;
            for (int index = 0;index <= length - 1;index++)
            {
                char currentChar = word[index];
                Console.WriteLine(currentChar);
            }
        }
    }
}
