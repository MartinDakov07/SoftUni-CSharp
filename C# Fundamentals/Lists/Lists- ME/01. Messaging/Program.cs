using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string text = Console.ReadLine();
            List<char> message = new List<char>();       
            for(int i = 0; i < text.Length; i++)
            {
                message.Add(text[i]);
            }
            foreach(int number in numbers)
            {
                int index = 0;
                string length = number.ToString();
                for(int i = 0; i < length.Length; i++)
                {
                    index += int.Parse(length[i].ToString());
                }
                if(index > text.Length)
                {
                    index = index - text.Length;
                }
                Console.Write(message[index]);
                message.RemoveAt(index);
            }
        }
    }
}
