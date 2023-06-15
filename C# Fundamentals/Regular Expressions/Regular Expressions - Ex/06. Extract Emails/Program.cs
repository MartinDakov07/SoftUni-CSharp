using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;
namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\s\b[a-zA-Z\d]+([-._][a-zA-Z\d]+)*[@][a-zA-z]+([-][a-zA-z]+)*([.]([a-zA-z]+([-][a-zA-z]+)*))+";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine(String.Join("\n", matches));
        }
    }
}
