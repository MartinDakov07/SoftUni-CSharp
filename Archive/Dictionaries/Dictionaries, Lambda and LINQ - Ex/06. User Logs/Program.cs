using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _06._User_Logs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> messages = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] commandArg = command.Split(new char[] {'=',' '},StringSplitOptions.RemoveEmptyEntries);
                string ip = commandArg[1];
                string user = commandArg[commandArg.Length - 1];
                if (!messages.ContainsKey(user))
                {
                    messages.Add(user, new Dictionary<string, int>());
                    messages[user].Add(ip, 1);
                }
                else
                {
                    if (messages[user].ContainsKey(ip))
                    {
                        messages[user][ip]++;
                    }
                    else
                    {
                        messages[user].Add(ip, 1);
                    }
                }
                command = Console.ReadLine();
            }
            foreach(var message in messages.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{message.Key}:");                               
                Console.Write(string.Join(", ",message.Value
                    .Select(x=>$"{x.Key} => {x.Value}")));
                Console.WriteLine('.');
            }
        }
    }
}
