using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
namespace _06._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ', '\\', '/', '(', ')' },StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex(@"\b([A-Za-z]{1}[A-Za-z0-9\_]{2,25})\b");
            List<string> validNames = new List<string>();
            foreach(var name in names)
            {
                Match match = pattern.Match(name);
                if (match.Success)
                {
                    validNames.Add(match.Value);
                }
            }
            List<string> bestNames = new List<string>(2);
            int bestLength = int.MinValue;
            int length = 0;
            for(int i = 1;i <= validNames.Count; i++)
            {
                int currLength = validNames[i - 1].Length;
                if (i % 2 == 0)
                {
                    length += currLength;
                    if(length > bestLength)
                    {
                        bestNames.Clear();
                        bestNames.Add(validNames[i - 1]);
                        bestNames.Add(validNames[i]);
                    }                   
                }
                else
                {
                    length += currLength;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,bestNames));
        }
    }
}
