using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
using System.Runtime.CompilerServices;

namespace _07._TakeSkip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> message = Console.ReadLine().ToList(); 
            List<int> numbers = new List<int>();
            for(int i = 0; i< message.Count; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    numbers.Add(int.Parse(message[i].ToString())); 
                    message.RemoveAt(i);
                    i--;
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for(int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
            int startIndex = 0;
            string encryptMessage = null;
            for(int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int skipCount = skipList[i];
                for(int j = startIndex; j < message.Count; j++)//FIRST YOU TAKE,THEN YOU SKIP
                {
                    int count = j;
                    for(int k = 0; k < takeCount; k++)
                    {
                        encryptMessage += message[count++];                        
                        if (count >= message.Count)
                        {
                            break;
                        }
                        
                    }
                    break;
                }
                startIndex += takeCount + skipCount;
            }
            Console.WriteLine(encryptMessage);
        }
    }
}
