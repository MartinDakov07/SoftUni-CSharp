using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    List<Team> teams = new List<Team>();
                    int numOfTeams = int.Parse(Console.ReadLine());
                    for(int i = 0; i < numOfTeams; i++)
                    {
                        string[] team = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                        string user = team[0];
                        string teamName = team[1];
                        if (TeamAlreadyExists(teams, teamName))
                        {
                            Console.WriteLine($"Team {teamName} was already created!");
                        }
                        else if (AlreadyCreatedTeam(teams, user))
                        {
                            Console.WriteLine($"{user} cannot create another team!");
                        }
                        else
                        {
                            Team newTeam = new Team(teamName, user);
                            teams.Add(newTeam);
                            Console.WriteLine($"Team {teamName} has been created by {user}!");
                        }
                    }
                    string command = Console.ReadLine();
                    while(command != "end of assignment")
                    {
                        string[] commandArg = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                        string creator = commandArg[0];
                        string teamName = commandArg[1];
                        if (!TeamAlreadyExists(teams, teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist!");
                        }
                        else if (AlreadyInTeam(teams, creator))
                        {
                            Console.WriteLine($"Member {creator} cannot join team {teamName}!");
                        }
                        else
                        {
                            Team teamToJoin = teams.First(t => t.Name == teamName);
                            teamToJoin.AddMember(creator);
                        }
                        command = Console.ReadLine();   
                    }
                    List<Team> teamsWithMembers = teams
                        .Where(t => t.Members.Count > 0)
                        .OrderByDescending(t => t.Members.Count)
                        .ThenBy(t => t.Name)
                        .ToList();
                    foreach(Team team in teamsWithMembers)
                    {
                        Console.WriteLine($"{team.Name}");
                        Console.WriteLine($"- {team.Creator}");
                        foreach(string member in team.Members.OrderBy(t => t))
                        {
                            Console.WriteLine($"-- {member}");
                        }
                       
                    }
                    List<Team> teamsToDisband = teams
                        .Where(t => t.Members.Count == 0)
                        .OrderBy(t => t.Name)
                        .ToList();
                    Console.WriteLine("Teams to disband:");
                    foreach(Team disbandTeam in teamsToDisband)
                    {
                        Console.WriteLine($"{disbandTeam.Name}");
                    }
                }
                static bool AlreadyCreatedTeam(List<Team> team, string creator)
                {
                    return team.Any(t => t.Creator == creator);
                }
                static bool TeamAlreadyExists(List<Team> team, string teamName)
                {
                    return team.Any(t => t.Name == teamName);
                }
                static bool AlreadyInTeam(List<Team>team, string creator)
                {
                    return team.Any(t => t.Members.Contains(creator)) || team.Any(t=>t.Creator == creator);
                }
            }
            public class Team
            {
                public readonly List<string> members;
                public Team (string name, string creator)
                 {
                    this.Name = name;
                    this.Creator = creator;
            
                    this.members = new List<string>();
                 }
                public string Name { get; set; }
                public string Creator { get; set; }
                public List<string> Members => this.members;
                public void AddMember(string memberName)
                {
                    this.members.Add(memberName);
                }
            }
        }  
    }
}