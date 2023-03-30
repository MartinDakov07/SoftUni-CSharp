using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatingWord(word, count); 
            
            Console.WriteLine(result);
        }
        static string RepeatingWord(string word, int count)
        {
            string result = "";
            for(int i = 0; i < count; i++)
            {
                result += word;
            }
            return result;
        }
    }
}
