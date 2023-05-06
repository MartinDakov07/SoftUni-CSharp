using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i];
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftSide = String.Join("", ticket.Take(10));
                string rightSide = String.Join("", ticket.Skip(10));
                string regex = @"([@#$^])\1{5,9}";
                MatchCollection leftMatch = Regex.Matches(leftSide, regex);
                MatchCollection rightMatch = Regex.Matches(rightSide, regex);
                if ((leftMatch.Count > 0 && rightMatch.Count > 0) &&
                (leftMatch[0].Value.Contains(rightMatch[0].Value) ||
                rightMatch[0].Value.Contains(leftMatch[0].Value)))
                {
                    char winningSymbol = leftMatch[0].Value[0];
                    int winningLength = Math.Min(leftMatch[0].Value.Length, rightMatch[0].Value.Length);
                    string output = $"ticket \"{ticket}\" - {winningLength}{winningSymbol}";
                    if (winningLength == 10) output += " Jackpot!";
                    Console.WriteLine(output);
                    
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                        
            }     
        }                   
    }
}
