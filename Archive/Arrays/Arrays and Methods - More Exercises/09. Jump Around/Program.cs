using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _09._Jump_Around
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int firstNum = numbers[0];
            bool noExit = false;
            if(firstNum > numbers.Length - 1)//if the first num is already unavailable, stop the program and the print the number on the index 0
            {
                sum += firstNum;
                Console.WriteLine(sum);
                return;
            }
            else
            {
                sum += firstNum;//the firstNum will always be on index 0
                while (true)
                {
                   for(int i = firstNum;i < numbers.Length; i++)//start from the num on index 0 
                   {
                        if (numbers[i]+i > numbers.Length - 1)//if we can't go on the right - lets say length 10, but you have index 6, and on index 6 the number is 5(6+5=11,which means you can't go on the right),and we go on the left we will get on index 1(6-5=1)
                        {
                            if (numbers[i] < numbers.Length-1 - i)//here we check if our numbers is less than TOTAL LENGTH - OUR INDEX, which will get us to all the indexes on the left,if they are more we cant move it
                                //then we check if we can go on the left,let's say we have length 6, and we are on index 3, and the number on index 3 is 4(3+4 = 7), we can't go on the right, so we try left(3-4=-1), we cant go on the left, so we stop the program
                            {
                                sum += numbers[i];//we sum and break
                                noExit = true;
                                break;
                            }
                            else//if the indexes on the left are less than our number, we can move it
                            {
                                sum += numbers[i];
                                i = i-numbers[i];
                                if (i < 0)//if we get invalid index after declining the index- break.
                                {
                                    noExit = true;
                                    break;
                                }
                                i--;
                            }
                        }
                        else//This is if we can move our index on the right (num on index is less than the length)
                        {
                            sum += numbers[i];
                            i = numbers[i]+i;                           
                            i--;
                        }
                   }
                    if (noExit)//If we can't move-stop the loop2 3 5 7 5 4 8 4
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
