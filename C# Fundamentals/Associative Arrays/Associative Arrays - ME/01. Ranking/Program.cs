using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Numerics;
namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,string> contests = new Dictionary<string,string>();
           SortedDictionary<string,Dictionary<string,int>> contestersInfo = new SortedDictionary<string,Dictionary<string,int>>();
            string command = Console.ReadLine();
            while(command != "end of contests")
            {
                string[] commandArg = command.Split(':');
                string contest = commandArg[0];
                string password = commandArg[1];
                contests.Add(contest, password);
                command = Console.ReadLine();
            }
            string input = Console.ReadLine();
            while(input != "end of submissions")
            {
                string[] contesterArg = input.Split("=>");
                string contest = contesterArg[0];
                string password = contesterArg[1];
                string username = contesterArg[2];
                int points = int.Parse(contesterArg[3]);
                
                if (contests.ContainsKey(contest))
                {
                    if(contests[contest] == password)
                    {
                        if (contestersInfo.ContainsKey(username) && contestersInfo[username].ContainsKey(contest))
                        {
                            if(contestersInfo[username][contest] < points)
                            {
                                contestersInfo[username][contest] = points;
                            }
                        }
                        else if (contestersInfo.ContainsKey(username))
                        {
                            contestersInfo[username].Add(contest, points);
                        }
                        else
                        {
                            contestersInfo.Add(username, new Dictionary<string, int>());
                            contestersInfo[username].Add(contest, points);
                        }
                        
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                input = Console.ReadLine();
            }
            string bestUser = "";
            int bestPoints = 0;
            foreach(var contester in contestersInfo)
            {
                if(contester.Value.Values.Sum() > bestPoints)
                {
                    bestUser = contester.Key;
                    bestPoints = contester.Value.Values.Sum();  
                }
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine($"Ranking: ");
            foreach(var contester in contestersInfo)
            {
                Console.WriteLine($"{contester.Key}");
                Console.WriteLine(String.Join("\n",contester.Value
                    .OrderByDescending(x => x.Value)
                    .Select(y => $"#  {y.Key} -> {y.Value}")));
            }
        }
    }
}
