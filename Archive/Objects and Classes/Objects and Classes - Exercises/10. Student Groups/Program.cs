using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.Globalization;
using System.Drawing;

namespace _10._Student_Groups
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }
        class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }      
        }
        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }
        static void Main(string[] args)
        {
            
            List<Town> towns = ReadTownAndStudents();
            List<Group> groups = DistributeStudentsIntoGroups(towns);
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (Group group in groups.OrderBy(g => g.Town.Name))
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", group.Students.Select(s => s.Email).ToList()));
            }

        }

        static List<Town> ReadTownAndStudents()
        {
            List<Town> towns = new List<Town>();
            string command = Console.ReadLine();
            while(command != "End")
            {
                if (command.Contains("=>"))//if the input contains it,that means our input contains town
                {
                    string[] commandArg = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                    string townName = commandArg[0].Trim();
                    int seatCount = int.Parse(commandArg[1].Trim().Split(' ')[0]);
                    Town town = new Town() { Name = townName, SeatsCount = seatCount, Students = new List<Student>()};//make our town
                    towns.Add(town);
                }
                else
                {
                    string[] commandArg = command.Split('|',StringSplitOptions.RemoveEmptyEntries);
                    string studentName = commandArg[0].Trim();
                    string email = commandArg[1].Trim();
                    DateTime registrationDate = DateTime.ParseExact(commandArg[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    Student student = new Student() { Name = studentName, Email = email, RegistrationDate = registrationDate };
                    Town studentTown = towns.Last();//get the last entered town
                    studentTown.Students.Add(student);//add the student to the town
                }
                command = Console.ReadLine();
            }
            return towns;
        }
        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            foreach(var town in towns)
            {
                IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);//here we get our students from the current town-ordered
                while (students.Any())//check if the collection contains any elements
                {
                    var group = new Group();//make our group
                    group.Town = town;//group town
                    group.Students = students.Take(group.Town.SeatsCount).ToList();//get the students that can get in 1 group
                    students = students.Skip(group.Town.SeatsCount);//remove the students
                    groups.Add(group);//add our groups
                }
            }
            return groups;
        }
    }
}
