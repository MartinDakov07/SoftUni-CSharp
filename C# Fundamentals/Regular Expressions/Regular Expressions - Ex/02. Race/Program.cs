using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Read the participaters:
            string[] participaters = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            //2.Make our pattern:
            string pattern = @"(?<names>[A-Za-z])|(?<distance>[0-9])";
            //3.Make dictionary to keep our information:
            Dictionary<string,int> playersInfo = new Dictionary<string, int>();
            //4.Add all participaters in our Dictionary:
            foreach(string participant in participaters)
            {
                playersInfo.Add(participant, 0);
            } 

            //5.Write the information for every player:
            string player = Console.ReadLine();
            //6.Insert out destination for each player:
           
            //Create String Builder to keep our players information:
            StringBuilder names = new StringBuilder();
            while(player != "end of race")
            {
                int distance = 0;
                MatchCollection matches = Regex.Matches(player,pattern); 
                foreach(Match match in matches)
                {
                    //int currDistance = int.Parse(match.Groups["distance"].Value);
                    if (int.TryParse(match.Groups["distance"].Value, out int currDistance))
                    {
                        distance += currDistance;
                    }
                    else
                    {
                        string currName = match.Groups["names"].Value;
                        names.Append(currName);
                    }
                }
                if (playersInfo.ContainsKey(names.ToString()))
                {
                    playersInfo[names.ToString()]+= distance;
                }
                names.Clear();
                player = Console.ReadLine();
            }
            playersInfo = playersInfo
                .OrderByDescending(x => x.Value)
                .ToDictionary(x=>x.Key,y=> y.Value);
            int i = 1;
            foreach(var (currName,distance) in playersInfo)
            {
               if(i == 1)
               {
                    Console.WriteLine($"1st place: {currName}");
               }
               else if(i == 2)
               {
                    Console.WriteLine($"2nd place: {currName}");
               }
               else if (i == 3)
               {
                    Console.WriteLine($"3rd place: {currName}");
                    break;
               }
               i++;
            }

        }
    }
}
