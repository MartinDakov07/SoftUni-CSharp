using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);               

            double multiplyOrDivide = 0;
            double resultNumber = 0;
            double sum = 0;

            foreach(string word in input)
            {                

                char firstSymbol = word[0]; 
                char lastSymbol = word[word.Length - 1]; 

                int positionFirs = char.ToUpper(firstSymbol) - 64; //it doesnt matter whether the number is lower or upper case
                int positionLast = char.ToUpper(lastSymbol) - 64; 

                string wordNum = word.Substring(1, word.Length - 2); 
                double number = double.Parse(wordNum);

                if (char.IsUpper(firstSymbol))
                {
                    multiplyOrDivide = number / positionFirs;
                }
                else
                {
                    multiplyOrDivide = number * positionFirs;
                }

                if (char.IsUpper(lastSymbol))
                {
                    resultNumber = multiplyOrDivide - positionLast;
                }
                else
                {
                    resultNumber = multiplyOrDivide + positionLast;
                }

                sum += resultNumber;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
