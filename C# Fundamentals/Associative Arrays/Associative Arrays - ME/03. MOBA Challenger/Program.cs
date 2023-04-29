using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _03._MOBA_Challenger
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            while (command != "Season end")
            {
                string[] playerArg = command.Split(new string[] { " -> ", " vs " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (playerArg.Length == 3)
                {
                    AddPlayer(players, playerArg[0], playerArg[1], int.Parse(playerArg[2]));
                }
                else if (playerArg.Length == 2)
                {
                    Duel(players, playerArg[0], playerArg[1]);
                }
                command = Console.ReadLine();
            }
            PrintResult(players);
        }
        private static void AddPlayer(Dictionary<string, Dictionary<string, int>> players, string player, string position, int skill)
        {
            if (!players.ContainsKey(player))
            {
                players.Add(player, new Dictionary<string, int>());
            }
            if (!players[player].ContainsKey(position))
            {
                players[player].Add(position, skill);
            }
            if (players[player][position] < skill)
            {
                players[player][position] = skill;
            }

        }
        private static void Duel(Dictionary<string, Dictionary<string, int>> players, string player1, string player2)
        {
            if (!players.ContainsKey(player1) || !players.ContainsKey(player2))
            {
                return;
            }
            bool player1Remove = false;
            bool player2Remove = false;
            foreach (var player in players[player1])
            {
                if (players[player2].ContainsKey(player.Key))
                {
                    if (players[player1].Values.Sum() > players[player2].Values.Sum())
                    {
                        player2Remove = true;
                    }
                    else if (players[player2].Values.Sum() > players[player1].Values.Sum())
                    {
                        player1Remove = true;
                    }
                    else
                    {
                        break;
                    }
                }
                if (player1Remove)
                {
                    players.Remove(player1);
                }
                else if (player2Remove)
                {
                    players.Remove(player2);
                }
            }
        }
        private static void PrintResult(Dictionary<string, Dictionary<string, int>> players)
        {
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
    //Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
    //string input;
    //    while ((input = Console.ReadLine()) != "Season end")
    //    {
    //        string[] tokens = input.Split(new string[] { " -> ", " vs " }, StringSplitOptions.None);
    //        if (tokens.Length == 3) AddPlayerInfo(players, tokens[0], tokens[1], int.Parse(tokens[2]));
    //        else if (tokens.Length == 2) PlayOutDuel(players, tokens[0], tokens[1]);
}   //
        //  DisplayResults(players);
    //    private static void AddPlayerInfo(Dictionary<string, Dictionary<string, int>> players, string playerName, string position, int skill)
    //    {
    //        if (!players.ContainsKey(playerName))
    //            players.Add(playerName, new Dictionary<string, int>());
    //        if (!players[playerName].ContainsKey(position))
    //            players[playerName].Add(position, skill);
    //        if (players[playerName][position] < skill)
    //            players[playerName][position] = skill;
    //    }
    //
    //
    //    private static void PlayOutDuel(Dictionary<string, Dictionary<string, int>> players, string player1Name, string player2Name)
    //    {
    //        if (!players.ContainsKey(player1Name) || !players.ContainsKey(player2Name)) return;
    //        bool toRemovePlayer1 = false;
    //        bool toRemovePlayer2 = false;
    //        foreach (var kvp in players[player1Name])
    //            if (players[player2Name].ContainsKey(kvp.Key))
    //            {
    //                if (players[player1Name].Values.Sum() > players[player2Name].Values.Sum())
    //                    toRemovePlayer2 = true;
    //
    //                else if (players[player1Name].Values.Sum() < players[player2Name].Values.Sum())
    //                    toRemovePlayer1 = true;
    //
    //                else break;
    //            }
    //        if (toRemovePlayer1) players.Remove(player1Name);
    //        else if (toRemovePlayer2) players.Remove(player2Name);
    //    }
    //
    //
    //    private static void DisplayResults(Dictionary<string, Dictionary<string, int>> players)
    //    {
    //        foreach (var player in players
    //                 .OrderByDescending(x => x.Value.Values.Sum())
    //                 .ThenBy(x => x.Key))
    //        {
    //            Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
    //            Console.WriteLine(String.Join("\n", player.Value
    //                .OrderByDescending(x => x.Value)
    //                .ThenBy(x => x.Key)
    //                .Select(x => $"- {x.Key} <::> {x.Value}")));
    //        }
    //    }
    //}   
         









