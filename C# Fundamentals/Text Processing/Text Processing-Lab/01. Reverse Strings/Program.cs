using System;
using System.Linq;
namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "end")
            {
                ReverseWord(word);
                
                word = Console.ReadLine();
            }            
        }
        static void ReverseWord(string word)
        {
            string reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            Console.WriteLine($"{word} = {reversed}");
        }
    }
}
