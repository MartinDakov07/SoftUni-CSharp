using System;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace _02._Email_me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@');
            int afterEmail = 0;
            int beforeEmail = 0;           
            string username = email[0];
            string domain = email[1];
            for(int i = 0; i < username.Length;i++)
            {                
                beforeEmail += (int)username[i];
            }
            for(int i = 0; i < domain.Length; i++)
            {
                afterEmail += (int)domain[i];
            }
            if(beforeEmail - afterEmail >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
