using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _06._Replace_a_Tag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCounter = 0;
            string input = "";
            string pattern = @"(<a.*?\w*?.*?)=(.*?)>(.*?)(<\/a>)";

            List<string> list = new List<string>();

            while (rowCounter < 100)
            {
                input = Console.ReadLine();

                //if input is "end"- then break
                if (input == "end")
                {
                    break;
                }
                else
                {
                    var matches = Regex.Matches(input, pattern);

                    string replacer = "[URL href=$2]$3[/URL]";
                    var replaced = Regex.Replace(input, pattern, replacer);

                    input = replaced;
                    list.Add(input);
                    rowCounter++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, list));
            Console.WriteLine();
        }
    }
}
