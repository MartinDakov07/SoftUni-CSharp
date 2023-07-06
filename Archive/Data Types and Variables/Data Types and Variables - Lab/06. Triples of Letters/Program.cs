using System;

namespace _06._Triples_of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                char firstL = (char)('a' + i);
                for(int j = 0; j < n; j++)
                {
                    char secondL = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        char thirdL = (char)('a' + k);
                        string letter = firstL.ToString() + secondL.ToString() + thirdL.ToString();
                        Console.WriteLine(letter);
                    }
                }
            }
        }
    }
}
