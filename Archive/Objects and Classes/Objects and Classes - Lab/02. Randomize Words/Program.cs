using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _02._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();
            for(int i = 0; i < text.Length; i++)
            {
                int randomIndex = rnd.Next(0, text.Length);
                var a = text[randomIndex];
                var b = text[i];
                text[randomIndex] = b;
                text[i] = a;
            }
            Console.WriteLine(string.Join(Environment.NewLine,text));
        }
    }
}
