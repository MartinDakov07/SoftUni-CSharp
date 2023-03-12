using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // буква     a  e  i  o  u

            // стойност 1  2  3  4  5
            string word = Console.ReadLine();
            int lenghtOfWord =word.Length;
            int sum = 0;
            for (int index = 0;index < lenghtOfWord; index++)
            {
                char currentChar = word[index];
                switch (currentChar)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
