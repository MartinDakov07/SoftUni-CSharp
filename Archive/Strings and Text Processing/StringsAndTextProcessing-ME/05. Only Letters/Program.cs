using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
namespace _05._Only_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();           
            for(int i = 0; i < text.Length-1; i++)
            {                
                if (char.IsDigit(text[i]))
                {                   
                    int removeCount = 1;
                    for(int j = i; j < text.Length - 1; j++)
                    {                        
                        if (char.IsDigit(text[j + 1]))
                        {
                            removeCount++;
                        }
                        else if (char.IsLetter(text[j + 1]))
                        {
                            char letter = text[j + 1];
                            text = text.Remove(i,removeCount);
                            text = text.Insert(i, letter.ToString());
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
