using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace _01._Censorship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();
            sentence = sentence.Replace(word, new string('*', word.Length));
            Console.WriteLine(sentence);
        }
    }
}
