using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();
            
            while (command != "Done")
            {
                string[] commandArg = command.Split(' ');
                string commandType = commandArg[0];
                if(commandType == "TakeOdd")
                {
                    StringBuilder newPass = new StringBuilder();
                    for (int i =1; i < password.Length; i+=2)
                    {
                      newPass.Append(password[i]);  
                    }
                    password = newPass.ToString();
                    Console.WriteLine(password);
                }
                else if(commandType == "Cut")
                {
                    int index = int.Parse(commandArg[1]);
                    int length = int.Parse(commandArg[2]);
                    string substring = password.Substring(index, length);
                    int indexOf = password.IndexOf(substring);
                    password = password.Remove(indexOf, length);
                    Console.WriteLine(password);
                }
                else if(commandType == "Substitute")
                {
                    string substring = commandArg[1];
                    string subtitute = commandArg[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, subtitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
        //this exam is from other exercise, except the other two(in case u come back to check for smt
    }
}
