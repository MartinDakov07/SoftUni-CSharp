using System;

namespace _15.__Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            string search = "p";
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i].ToString() == search)//You cant compare char with string
                {
                    hasMatch = true;

                    int endIndex = jump;
                    string matchedString = "";

                    if (endIndex >= text.Length-i)//This is if the word is somewhere further in the word
                    {
                        endIndex = text.Length-i; // Give the length of the word
                        
                       matchedString = text.Substring(i, endIndex);//Make sure the program wont break
                    }
                    else
                    {
                        matchedString = text.Substring(i, endIndex + 1);
                    }
                                       
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
