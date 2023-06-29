using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _14._Magic_Letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            int firstInt = (int)firstLetter;
            int secondInt = (int)secondLetter;
            int thirdInt = (int)thirdLetter;            
            string text = "";
            for(int i = firstInt; i <= secondInt; i++)
            {
                for (int j = firstInt; j <= secondInt; j++)
                {
                    for (int k = firstInt; k <= secondInt; k++)
                    {
                        string firstChar = ((char)i).ToString();
                        string secondChar = ((char)j).ToString();
                        string thirdChar = ((char)k).ToString();
                        text += firstChar + secondChar + thirdChar;
                        if (!text.Contains(thirdLetter))
                        {
                            Console.Write($"{text} ");
                        }
                        text = "";
                    }
                }
            }
        }
        
    }
}
