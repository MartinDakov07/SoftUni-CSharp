using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < input.Length; i++)
            {
                string[] nameAndCost = input[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(nameAndCost[0], double.Parse(nameAndCost[1]));
                people.Add(person);
            }
            List<Product> products = new List<Product>();
            string[] secondInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < secondInput.Length; i++)
            {
                string[] nameAndCost = secondInput[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product(nameAndCost[0], double.Parse(nameAndCost[1]));     
                products.Add(product);
            }
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] commandArg = command.Split();
                string person = commandArg[0];
                string product = commandArg[1];
                int indexPerson = people.FindIndex(x => x.Name == person);
                int indexProduct = products.FindIndex(x => x.Name == product);
                if(people[indexPerson].Money < products[indexProduct].Cost)
                {
                    Console.WriteLine($"{person} can't afford {product}");
                }
                else
                {
                    Console.WriteLine($"{person} bought {product}");
                    people[indexPerson].Money -= products[indexProduct].Cost;                    
                    people[indexPerson].BagOfProducts.Add(products[indexProduct]);
                }
                command = Console.ReadLine();
            }
            foreach (Person person in people)
            {
                if(person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.BagOfProducts.Select(x=>x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
        public class Person
        {
            public Person(string name, double money)
            {
                Name = name;
                Money = money;
                BagOfProducts = new List<Product>();
            }
            public string Name { get; set; }    
            public double Money { get; set; }
            public List<Product> BagOfProducts { get; set; }
        }
        public class Product
        {
            public Product(string name, double cost)
            {
                Name= name;
                Cost = cost;
            }

            public string Name { get; set; }
            public double Cost { get; set; }    
        }
    }
}
