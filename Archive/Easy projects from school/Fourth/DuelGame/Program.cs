using System;
using System.Collections.Generic;
using System.Linq;

namespace helpProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string input;

            while ((input = Console.ReadLine()) != "Season end")
            {
                var statement = input.Split(" ",StringSplitOptions.None).ToList();

                if (statement.Count < 5)
                {
                    string movement = string.Join("", statement);
                    var action = movement.Split("vs", StringSplitOptions.RemoveEmptyEntries).ToList();
                    string dueler1 = action[0];
                    string dueler2 = action[1];

                    if (players.ContainsKey(dueler1) && players.ContainsKey(dueler2))
                    {
                        foreach (var pos1 in players[dueler1])
                        {
                            foreach (var pos2 in players[dueler2])
                            {
                                if (pos1.Key == pos2.Key)
                                {
                                    int player1TotalPoints = players[dueler1].Values.Sum();
                                    int player2TotalPoints = players[dueler2].Values.Sum();
                                    if (player1TotalPoints > player2TotalPoints)
                                    {
                                        players.Remove(dueler2);
                                    }
                                    else if (player2TotalPoints > player1TotalPoints)
                                    {
                                        players.Remove(dueler1);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    string movement = string.Join("", statement);
                    var action = movement.Split("->",StringSplitOptions.None).ToList();
                    string playerName = action[0];
                    string playerPosition = action[1];
                    int skill = int.Parse(action[2]);

                    if (!players.ContainsKey(playerName))
                    {
                        players.Add(playerName, new Dictionary<string, int>());                        
                    }
                    if (!players[playerName].ContainsKey(playerPosition))
                    {
                        players[playerName].Add(playerPosition, skill);
                    }
                    if (players[playerName][playerPosition] < skill)
                    {
                        players[playerName][playerPosition] = skill;
                    }
                        
                    
                }
            }
            //PRINTS
            foreach (var player in players
                 .OrderByDescending(x => x.Value.Values.Sum())
                 .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                Console.WriteLine(String.Join("\n", player.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .Select(x => $"- {x.Key} <::> {x.Value}")));
            }
        }
    }
}

