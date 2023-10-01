using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _03._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach(var word in banWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
