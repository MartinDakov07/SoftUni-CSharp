using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,int>> contests = new Dictionary<string,Dictionary<string,int>>();
            Dictionary<string, Dictionary<string, int>> individuals = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            while(command != "no more time")
            {
                string[] commandArg = command.Split(" -> ");
                string username = commandArg[0];
                string contest = commandArg[1];
                int points = int.Parse(commandArg[2]);
                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());                                    
                }
                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, points);
                }
                if (!individuals.ContainsKey(username))
                {
                    individuals.Add(username, new Dictionary<string, int>());
                }
                if (!individuals[username].ContainsKey(contest))
                {
                    individuals[username].Add(contest, points);
                }
                if (contests[contest][username] < points)
                {
                    contests[contest][username] = points;
                    individuals[username][contest] = points;
                }
                command = Console.ReadLine();
            }
            foreach(var contest in contests)
            {
                int numOfContests = 1;
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                Console.WriteLine(String.Join("\n", contest.Value
                                          .OrderByDescending(x => x.Value)
                                          .ThenBy(y => y.Key)
                                          .Select(y => $"{numOfContests++}. {y.Key} <::> {y.Value}")));

            }
            Console.WriteLine("Individual standings:");                      
               
            //Console.WriteLine(String.Join("\n",individuals.OrderByDescending(x => x.Value.Values.Sum())
            //    .ThenBy(y => y.Key)
            //    .Select(y => $"{numOfParticipants++}. {y.Key} -> {y.Value}")));
            int numParticipants = 1;
            Console.WriteLine(String.Join("\n", individuals.OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(y => y.Key)
                .Select(y => $"{numParticipants++}. {y.Key} -> {y.Value.Values.Sum()}")));

        }
    }
}
