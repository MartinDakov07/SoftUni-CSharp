using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
namespace _04._Morse_Code_Upgraded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
            StringBuilder message = new StringBuilder();
            foreach(var letter in text)
            {
                int one = 0;
                int zero = 0;
                int currSum = 0;
                for(int i = 0; i < letter.Length; i++)
                {
                    if (letter[i] == '1')
                    {
                        one++;
                    }
                    else if (letter[i] == '0')
                    {
                        zero++;
                    }
                }
                currSum = one * 5 + zero * 3;
                int count = 1;
                for(int i = letter.Length - 1; i > 0; i--)
                {
                    if (letter[i] == letter[i - 1])
                    {
                        count++;
                    }
                    else
                    {
                        if(count != 1)
                        {
                            currSum += count;
                            count = 1;
                        }                        
                    }
                }
                if (count != 1)
                {
                    currSum += count;                    
                }
                message.Append((char)currSum);
            }
            Console.WriteLine(message);
        }
    }
}
