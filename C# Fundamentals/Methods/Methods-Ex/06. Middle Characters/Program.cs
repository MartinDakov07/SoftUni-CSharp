using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string midlleChar = GetMiddleCharacter(word);
            Console.WriteLine(midlleChar);
            
        }
        private static string GetMiddleCharacter(string word)
        {
            {
                string midlleChar = string.Empty;
                if (word.Length % 2 == 0)
                {
                    midlleChar += word[word.Length / 2 - 1];
                    midlleChar += word[word.Length / 2];
                    return midlleChar;
                }
                else
                {
                    midlleChar += word[word.Length / 2];
                    return midlleChar;
                }

            }
            //string middlechar = string.Empty;
            //
            //if (input.Length % 2 == 0)
            //{
            //    middlechar += input[input.Length / 2 - 1];
            //    middlechar += input[input.Length / 2];
            //
            //    return middlechar;
            //}
            //else
            //{
            //    middlechar += input[input.Length / 2];
            //    return middlechar;
            //}
        }
        
       
    }
}
