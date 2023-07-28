using System;

namespace _03._English_Name_of_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string name = PrintNumName(num);
            Console.WriteLine(name);
        }
       static string PrintNumName(long num)
        {
            long lastDigit = num % 10;
            string name = null;
            
                if(lastDigit == 0)
                {
                   name = "zero";
                }
                                       
                else if(lastDigit == 1 || lastDigit == -1)
                {
                  name = "one";
                }
                                       
                else if(lastDigit == 2 || lastDigit == -2)
                {
                    name = "two";
                }
                                               
                else if(lastDigit == 3 || lastDigit == -3)
                {
                    name = "three";
                }
                                            
                else if(lastDigit == 4 || lastDigit == -4)
                {
                    name = "four";
                }
                                            
                else if(lastDigit == 5 || lastDigit == -5)
                {
                    name = "five";
                }
                                            
                else if(lastDigit == 6 || lastDigit == -6)
                {
                    name = "six";
                }
                                          
                else if(lastDigit == 7 || lastDigit == -7)
                {
                    name = "seven";
                }
                                           
                else if(lastDigit == 8 || lastDigit == -8)
                {
                    name = "eight";
                }
                                          
                else if(lastDigit == 9 || lastDigit == -9)
                {
                    name = "nine";
                }                       
            return name;
        }
    }
}
