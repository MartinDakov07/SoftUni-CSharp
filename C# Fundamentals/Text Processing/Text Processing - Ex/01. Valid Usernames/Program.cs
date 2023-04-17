using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            foreach(string name in names)
            {
                if (name.Length > 3 && name.Length < 16)
                {
                    bool isUsernameValid = true;
                    foreach(char c in name)
                    {
                        if(!(char.IsLetterOrDigit(c) || c == '_' || c == '-'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(name);
                    }
                }
                
            }
        }
    }
}
