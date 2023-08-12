using System;

namespace _09._Index_of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] allLetters = new char[]
            {
               'a','b','c',
               'd','e','f',
               'g','h','i',
               'j','k','l',
               'm','n','o',
               'p','q','r',
               's','t','u',
               'v','w','x',
               'y','z'
            };
            string message = Console.ReadLine();
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < allLetters.Length; j++)
                {
                    if (message[i].ToString() == allLetters[j].ToString())
                    {
                        Console.WriteLine($"{message[i]} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}
