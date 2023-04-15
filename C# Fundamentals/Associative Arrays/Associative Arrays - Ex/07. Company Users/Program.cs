using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();
            string[] teamInfo = Console.ReadLine().Split(" -> ");
            while(teamInfo[0] != "End")
            {
                string teamName = teamInfo[0];
                string teamId = teamInfo[1];
                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new List<string>());                   
                }                                            
                if (!teams[teamName].Contains(teamId))
                {
                    teams[teamName].Add(teamId);
                }
              
                teamInfo = Console.ReadLine().Split(" -> ");
            }
            foreach(var team in teams)
            {
                string teamName = team.Key;
                List<string> teamIds = team.Value;
                Console.WriteLine(teamName);
                foreach(string teamId in teamIds)
                {
                    Console.WriteLine($"-- {teamId}");
                }                                                         
            }

        }
    }
}
