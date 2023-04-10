using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string data = Console.ReadLine();
            while(data != "End")
            {
                string[] personArg = data.Split(" ");
                string name = personArg[0];
                string id = personArg[1];
                int age = int.Parse(personArg[2]);
                Person person = new Person(name,id,age);
                people.Add(person);
                data = Console.ReadLine();
            }
            List<Person> orderPeople = people
                .OrderBy(x => x.Age)
                .ToList();
            foreach(Person person in orderPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
    
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";

    }
}
