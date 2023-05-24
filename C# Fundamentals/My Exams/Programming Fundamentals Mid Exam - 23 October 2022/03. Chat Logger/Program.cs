using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string command = Console.ReadLine();
            while(command != "end")
            {
               List <string> commands = command.Split(" ").ToList();
                string commandArg = commands[0];
                string messages = commands[1];
                if(commandArg == "Chat")
                {
                    chat.Add(messages);
                }
                else if(commandArg == "Delete")
                {
                    if (chat.Contains(messages))
                    {
                        chat.Remove(messages);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if(commandArg == "Edit")
                {
                    string mesForEdit = commands[2];
                    if (chat.Contains(messages))
                    {
                        for(int i = 0; i < chat.Count; i++)
                        {
                            if(chat[i] == messages)
                            {
                                chat.RemoveAt(i);
                                chat.Insert(i, mesForEdit);
                                break;
                            }
                            
                        }

                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if(commandArg == "Pin")
                {
                    string messageCopy = messages;
                    if (chat.Contains(messages))
                    {
                        for(int i = 0; i < chat.Count; i++)
                        {
                            if(chat[i] == messages)
                            {
                                chat.RemoveAt(i);
                                chat.Add(messageCopy);
                                break;
                            }
                        }
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if(commandArg == "Spam")
                {
                    for(int i = 1; i < commands.Count; i++)
                    {
                        chat.Add(commands[i]);
                    }
                }
                command = Console.ReadLine();
            }
           for(int i = 0; i < chat.Count; i++)
            {
                Console.WriteLine(chat[i]);
            }
        }
    }
}
