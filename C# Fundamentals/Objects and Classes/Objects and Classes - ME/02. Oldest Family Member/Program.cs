using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family thisFamily = new Family();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ');
                thisFamily.AddMembers(personInfo[0], int.Parse(personInfo[1]));
            }
            Person printOldestPerson = thisFamily.GetOldestPerson();
            Console.WriteLine($"{printOldestPerson.Name} {printOldestPerson.Age}");
        }
        public class Person
        {
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
            public Person()
            {
                this.Name = "No name";
                this.Age = 0;
            }
            public string Name { get; set; }  
            public int Age { get; set; }
        }
        public class Family
        {
            public List<Person> People { get; set; }
            public void AddMembers(string name, int age)
            {
                Person member = new Person(name, age);
                People.Add(member);

            } 
            public Person GetOldestPerson()
            {
                return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
            }
            public Family()
            
            {
                this.People = new List<Person>();
            }

        }
    }
}
