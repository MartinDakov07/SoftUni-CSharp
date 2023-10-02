using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _04._Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach(string word in text)
            {

                string reversedWord = new string(word.Reverse().ToArray());
                if(word == reversedWord)
                {
                    if (!palindromes.Contains(word))
                    {
                        palindromes.Add(word);
                    }
                }                
            }
            Console.WriteLine(string.Join(", ",palindromes.OrderBy(p=>p)));
        }
    }
}
