using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _04._Fix_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while(name != "stop")
            {
                string email = Console.ReadLine();
                if(email.EndsWith("us") || email.EndsWith("uk"))
                {
                    name = Console.ReadLine();
                    continue;
                }
                else
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach(var email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
