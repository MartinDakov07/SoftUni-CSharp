using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            string pattern = @">>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quantity>\d+)(\.\d+){0,1}";
            double sum = 0;
            string input = Console.ReadLine();
            while(input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double furniturePrice = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    
                    sum += furniturePrice * quantity;
                    furniture.Add(furnitureName);
                }
                input = Console.ReadLine();
            }
            
            
                Console.WriteLine("Bought furniture:");
                foreach (string furnitureName in furniture)
                {
                    Console.WriteLine(furnitureName);
                }
                                       
            Console.WriteLine($"Total money spend: {sum:f2}");
            //string input = Console.ReadLine();
            //
            //double price = 0;
            //double quantity = 0;
            //double totalPrice = 0;
            //
            //bool isMatched = false;
            //
            //string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quantity>\d+)(\.\d+){0,1}";
            //List<string> nameList = new List<string>();
            //
            //while (input != "Purchase")
            //{
            //    //">>{furniture name}<<{price}!{quantity}"
            //    
            //    Match match = Regex.Match(input,pattern);
            //
            //    if (match.Success)
            //    {
            //        string furniture = match.Groups["furniture"].Value;                   
            //        price = double.Parse(match.Groups["price"].Value);
            //        quantity = double.Parse(match.Groups["quantity"].Value);
            //
            //        totalPrice += price * quantity;
            //        nameList.Add(furniture);
            //        isMatched = true;
            //    }
            //    input = Console.ReadLine();
            //}           
            //Console.WriteLine("Bought furniture:");
            //   foreach (string furnitureName in nameList)
            //   {
            //        Console.WriteLine(furnitureName);
            //   }
            //Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
