using System;
using System.Text.RegularExpressions;
namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Write our pattern:
            string pattern = @"^[^\$\%\.\|]*?\%(?<customer>[A-Z][a-z]+)\%[^\$\%\.\|]*?\<(?<product>\w+)\>[^\$\%\.\|]*?\|(?<quantity>\d+)\|[^\$\%\.\|]*?(?<price>\d+(\.\d+)?)\$[^\$\%\.\|]*?$";
            //2.Read our input from the console:
            string input = Console.ReadLine();
            double sum = 0;
            while(input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double totalPrice = quantity * price;
                    sum += totalPrice;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
