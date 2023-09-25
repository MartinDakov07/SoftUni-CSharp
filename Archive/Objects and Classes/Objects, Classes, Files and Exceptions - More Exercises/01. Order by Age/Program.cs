using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _01._Order_by_Age
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = commandArg[0];
                string id = commandArg[1];
                int age = int.Parse(commandArg[2]);
                Person person = new Person() { Name = name, ID = id, Age = age };
                people.Add(person);
                command = Console.ReadLine();
            }
            foreach(var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
