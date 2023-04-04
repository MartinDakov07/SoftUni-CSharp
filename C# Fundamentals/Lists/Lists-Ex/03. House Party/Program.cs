using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestsList = new List<string>();
            int guests = int.Parse(Console.ReadLine());
            for(int i = 0; i < guests; i++)
            {
                string command = Console.ReadLine();
                string[] members = command.Split();
                if(members.Length == 3)
                {
                    if (guestsList.Contains(members[0]))
                    {
                        Console.WriteLine($"{members[0]} is already in the list!");
                        continue;
                    }


                    guestsList.Add(members[0]);
                    
                    
                }
                else if(members.Length == 4)
                {
                    if (guestsList.Contains(members[0]))
                    {
                        guestsList.Remove(members[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{members[0]} is not in the list!");
                    }
                }
            }
            PrintPartyMemebers(guestsList);
        }
        static void PrintPartyMemebers(List<string> guestsList)
        {
            foreach(string member in guestsList)
            {
                Console.WriteLine(member);
            }
        }
    }
}
