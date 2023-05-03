using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morseSymbols = {".-","-...","-.-.","-..",".", 
            "..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--."
            ,"--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

            string[] letters = {"A","B","C","D","E","F","G","H","I","J","K","L","M"
            ,"N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

            string[] morseWords = Console.ReadLine().Split("|");
            List<string> message = new List<string>();
            foreach(string word in morseWords)
            {
                StringBuilder englWord = new StringBuilder();
                string[] symbols = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string symbol in symbols)
                {                    
                    for (int i = 0; i < morseSymbols.Length; i++)
                    {
                        if(morseSymbols[i] == symbol)
                        {
                            englWord.Append(letters[i]);
                            break;
                        }
                    }
                }
                message.Add(englWord.ToString());
            }
            Console.WriteLine(String.Join(" ",message));

        }
    }
}
