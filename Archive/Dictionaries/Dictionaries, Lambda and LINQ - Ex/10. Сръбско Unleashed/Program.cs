using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _10._Сръбско_Unleashed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> venues = new Dictionary<string, Dictionary<string, long>>();
            //This problem is all about checking the wrong data
            while(true)
            {
                string command = Console.ReadLine();
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(command == "End")
                {
                    break;
                }
                if(commandArg.Length < 4)//our data will be at least 4 symbols long
                {                    
                    continue;
                }
                bool isVenue = false;
                foreach(var element in commandArg)
                {
                    if (element.StartsWith("@"))//check if we have valid venue
                    {
                        isVenue = true;
                    }
                }
                if (!isVenue)
                {
                    continue;
                }

                long digit;
                bool isDigit = long.TryParse(commandArg[commandArg.Length - 1], out digit);//check if our last part of the array is num
                bool isDigitToo = long.TryParse(commandArg[commandArg.Length - 2], out digit);//and then the number before it

                if(!isDigit || !isDigitToo)//the the last parts of the array are not nums, skip the data
                {
                    continue;
                }

                string[] getPerformer = command.Split('@');//Lepa Brena @Sunny Beach 25 3500 -> Lepa Brena (first element)   Sunny Beach 25 3500 (second element)

                string singer = getPerformer[0];

                string[] tickets = getPerformer[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);//Sunny Beach 25 3500 -> 1.Sunny  2.Beach  3.25  4.3500

                long count = long.Parse(tickets[tickets.Length - 1]);
                long price = long.Parse(tickets[tickets.Length - 2]);

                long totalPrice = count * price;

                //and to get the venue:
                string[] getVenue = tickets.SkipLast(2).ToArray();//skip last removes the last n-elements

                string venue = string.Join(" ", getVenue);

                if (!venues.ContainsKey(venue))
                {
                    venues.Add(venue, new Dictionary<string, long>());
                    venues[venue].Add(singer, totalPrice);
                }
                else
                {
                    if (venues[venue].ContainsKey(singer))
                    {
                        venues[venue][singer] += totalPrice;
                    }
                    else
                    {
                        venues[venue].Add(singer, totalPrice);
                    }
                }
            }

            foreach(var venue in venues)
            {
                Console.WriteLine($"{venue.Key}");

                foreach(var singer in venue.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
