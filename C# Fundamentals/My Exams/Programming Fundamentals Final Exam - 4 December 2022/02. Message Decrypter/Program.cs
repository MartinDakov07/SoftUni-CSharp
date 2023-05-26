using System;
using System.Text.RegularExpressions;
namespace _02._Message_Decrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\%|\$)(?<tag>[A-Z][a-z]{2,})(\1): (\[(?<n1>[\d]+)\][|]\[(?<n2>[\d]+)\][|]\[(?<n3>[\d]+)\][|])$";
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string text = "";
                    int firstNum = int.Parse(match.Groups["n1"].Value);
                    int secondNum = int.Parse(match.Groups["n2"].Value);
                    int thirdNum = int.Parse(match.Groups["n3"].Value);
                    char uniOne = (char)firstNum;                
                    char uniTwo = (char)secondNum;
                    char uniThree = (char)thirdNum;
                    text = text + (char)uniOne + (char)uniTwo + (char)uniThree;
                    Console.WriteLine($"{match.Groups["tag"].Value}: {text}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
