using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _02._Phonebook_Upgrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandArgs = input.Split(' ');

                string command = commandArgs[0];

                if (command == "A")
                {
                    AddNewEntry(phoneBook, commandArgs);
                }
                else if (command == "S")
                {
                    PrintEntry(phoneBook, commandArgs);
                }
                else if (command == "ListAll")
                {
                    PrintAllEntries(phoneBook);
                }

                input = Console.ReadLine();
            }

        }

        private static void PrintAllEntries(SortedDictionary<string, string> phoneBook)
        {
            List<KeyValuePair<string, string>> orderedPhonebook = phoneBook.OrderBy(x => x.Key).ToList();

            foreach (var entry in orderedPhonebook)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }

        private static void PrintEntry(SortedDictionary<string, string> phoneBook, string[] commandArgs)
        {
            string contact = commandArgs[1];
            if (phoneBook.ContainsKey(contact))
            {
                Console.WriteLine("{0} -> {1}", contact, phoneBook[contact]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", contact);
            }
        }

        private static void AddNewEntry(SortedDictionary<string, string> phoneBook, string[] commandArgs)
        {
            string contact = commandArgs[1];
            string number = commandArgs[2];
            if (!phoneBook.ContainsKey(contact))
            {
                phoneBook.Add(contact, number);
            }
            else
            {
                phoneBook[contact] = number;
            }            
        }
    }
}
