using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for(int i = 0; i< n; i++)
            {
                string text = Console.ReadLine();
                string name = "";
                int age = 0;
                name =  GetName(text,name);
                age = GetAge(text, age);
                people.Add(name, age);
            }
            foreach(var person in people)
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old.");
            }
        }
        static string GetName(string text,string name)
        {
            int index = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == '@')
                {
                     index = i+1;                    
                }
                if(text[i] == '|')
                {
                    name = text.Substring(index, i-index);
                    break;
                }
            }
            return name;
        }
        static int GetAge(string text,int age)
        {
            int index = 0;
            for(int i = 0;i < text.Length; i++)
            {
                if(text[i] == '#')
                {
                    index = i+1;
                }
                if(text[i] == '*')
                {
                    age = int.Parse(text.Substring(index, i-index));
                    break;
                }
            }
            return age;
        }
        //simpler solution 
        //int numberOfLines = int.Parse(Console.ReadLine());
        //
        //    for (int i = 0; i<numberOfLines; i++)
        //    {
        //        string input = Console.ReadLine();
        //
        //string[] nameChunks = input.Split('@', '|');
        //string name = nameChunks[1];
        //
        //string[] ageChunks = input.Split('#', '*');
        //string age = ageChunks[1];
        //
        //Console.WriteLine($"{name} is {age} years old.");
    }
}

