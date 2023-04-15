using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> clubs = new Dictionary<string, List<string>>();
            string[] club = Console.ReadLine().Split(" : ",StringSplitOptions.RemoveEmptyEntries);            
            while(club[0] != "end")
            {
                string clubName = club[0];
                string student = club[1];
                if (!clubs.ContainsKey(clubName))
                {
                    clubs[clubName] = new List<string>();                   
                }                               
                clubs[clubName].Add(student);
                club = Console.ReadLine().Split(" : ");
            }
            foreach(var kvp in clubs)
            {
                string clubName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{clubName}: {students.Count}");
                foreach(string student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
