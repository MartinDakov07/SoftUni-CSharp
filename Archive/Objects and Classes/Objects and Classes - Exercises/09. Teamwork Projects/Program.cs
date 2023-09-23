using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Xml.Serialization;

namespace _09._Teamwork_Projects
{
    internal class Program
    {
        class Team
        {
            public readonly List<string> members;
            public string Name { get; set; }
            public string Creator { get; set; }
            public Team(string name, string creator)
            {
                this.Name = name;//Team name
                this.Creator = creator;//Team creator

                this.members = new List<string>();//Here we add our members
            }
            public List<string> Members => this.members; 
            public void AddMember(string memberName)
            {
                this.members.Add(memberName); // Here we add a new member to already created team
            }
        }
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string creator = command[0];
                string teamName = command[1];
                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if(teams.Any(t=>t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }              
                else
                {
                    Team team = new Team(teamName, creator);                    
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }                
            }
            string command2 = Console.ReadLine();
            while(command2 != "end of assignment")
            {
                string[] commandArg = command2.Split("->");
                string user = commandArg[0];
                string teamName = commandArg[1];
                if(!teams.Any(t=>t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if(teams.Any(t => t.Members.Contains(user)) || teams.Any(t => t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team existingTeam = teams.First(t => t.Name == teamName);
                    existingTeam.AddMember(user);
                }
                command2 = Console.ReadLine();
            }
            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            //Here we print all the teams
            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(t => t))//Keep in mind we need to order the members too
                {
                    Console.WriteLine($"-- {member}");
                }

            }
            //Here we get all teams with no members, and then order them by names - so we need to disband these teams!
            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();
            Console.WriteLine("Teams to disband:");
            //And at the end we print the teams for disband
            foreach (Team disbandTeam in teamsToDisband)
            {
                Console.WriteLine($"{disbandTeam.Name}");
            }
        }
    }
}
