using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _01._Largest_Common_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstText = Console.ReadLine().Split();
            string[] secondText = Console.ReadLine().Split();
            int lowerLength = Math.Min(firstText.Length, secondText.Length);
            int leftCorner = 0;
            int rightCorner = 0;
            for(int i = 0; i < lowerLength; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    leftCorner++;
                }
                else
                {
                    break;
                }                
            }
            Array.Reverse(firstText);
            Array.Reverse(secondText);
            for(int j = 0; j < lowerLength; j++)
            {
                if (firstText[j] == secondText[j])
                {
                    rightCorner++;
                }
                else
                {
                    break;
                }
            }
            int longerLength = Math.Max(leftCorner, rightCorner);
            Console.WriteLine(longerLength);
        }        
    }
}
