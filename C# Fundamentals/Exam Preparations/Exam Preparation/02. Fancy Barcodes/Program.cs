using System;
using System.Text.RegularExpressions;
namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@\#+)(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])(\@\#+)";
            Regex patternForDigits = new Regex(@"\d+");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                string barcode = Console.ReadLine();
                Match match = Regex.Match(barcode, pattern);
                if (match.Success)
                {
                    MatchCollection matches = patternForDigits.Matches(match.Value);
                    if(matches.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("",matches)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
