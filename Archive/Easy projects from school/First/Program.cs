using System;
using System.Runtime.Serialization.Formatters;

namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ako e string
            string text = Console.ReadLine();
            int middle = text.Length / 2;
            if(text.Length <= 20)
            {
                text = text.Remove(middle, text.Length - middle);
                for(int i = middle; i <= 20; i++)
                {
                    text = text.Insert(i, "*");
                }
            }
            Console.WriteLine(text);
        }
    }
}
