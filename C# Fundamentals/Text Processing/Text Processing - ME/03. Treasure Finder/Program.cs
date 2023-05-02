using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            string text = Console.ReadLine();
            while(text != "find")
            {
                StringBuilder encryptText = new StringBuilder();
                int index = 0;
                for (int i = 0; i < text.Length; i++)
                {                   
                    if (index == keys.Length)
                    {
                        index = 0;
                    }
                    encryptText.Append((char)(text[i] - keys[index]));
                    index++;
                }
                string[] typeTokens = encryptText.ToString().Split('&');
                string type = typeTokens[1];

                string[] coordinateTokens = encryptText.ToString().Split('<', '>');
                string coordinate = coordinateTokens[1];

                Console.WriteLine($"Found {type} at {coordinate}");
                text = Console.ReadLine();
            }
        } 
    }
}
