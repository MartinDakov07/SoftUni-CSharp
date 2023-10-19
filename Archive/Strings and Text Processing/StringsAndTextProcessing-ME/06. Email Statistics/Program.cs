using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace _06._Email_Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            Regex pattern = new Regex(@"^(?<username>[a-zA-Z]{5,})@(?<domain>(?<mailServer>[a-z]{3,})(?<topDomain>\.com|\.bg|\.org))$");
            for(int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();
                Match match = pattern.Match(email);
                if (match.Success)
                {
                    string username = match.Groups["username"].Value;
                    string domain = match.Groups["domain"].Value;
                    if (!emails.ContainsKey(domain))
                    {
                        emails.Add(domain, new List<string>());
                    }
                    if (!emails[domain].Contains(username))
                    {
                        emails[domain].Add(username);
                    }                    
                }
            }
            foreach (var email in emails.OrderByDescending(e => e.Value.Count))
            {
                Console.WriteLine($"{email.Key}:");
                foreach(var name in email.Value)
                {
                    Console.WriteLine($"### {name}");
                }
            }
        }
    }
}
