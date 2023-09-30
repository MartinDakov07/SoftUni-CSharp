using System;
using System.Linq;
using System.Text;
namespace _02._Count_Substring_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string textToFind = Console.ReadLine().ToLower();
            int findTextLenght = textToFind.Length;
            int matchCount = 0;
            for (int i = 0; i < text.Length; i++) 
            {
                if(i + findTextLenght > text.Length)
                {
                    break;
                }
                string currWord = text.Substring(i, findTextLenght);
                if(currWord == textToFind)
                {
                    matchCount++;
                }
            }
            Console.WriteLine(matchCount);
        }
    }
}
