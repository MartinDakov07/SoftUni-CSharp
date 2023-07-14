using System;
using System.Numerics;
namespace _18._Different_Integers_Size
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool canHappen = false;
            string num = Console.ReadLine();
            string message = "";
                try
                {
                    sbyte smallestNum = sbyte.Parse(num);
                    message += "* sbyte\n";
                    canHappen = true;
                }            
                catch
                {
                    
                }

                try
                {
                     byte smallerNum = byte.Parse(num);
                     message += "* byte\n";
                     canHappen = true;
                }
                catch
                {
                    
                }

                try
                {
                     short smallNum = short.Parse(num);
                     message += "* short\n";
                     canHappen = true;
                }
                catch
                {
                
                }

                try
                {
                    ushort bigNum = ushort.Parse(num);
                    message += "* ushort\n";
                    canHappen = true;
                }
                catch
                {
                
                }

                try
                {
                    int biggerNum = int.Parse(num);
                    message += "* int\n";
                    canHappen = true;
                }
                catch
                {
                
                }

                try
                {
                    uint biggestNum = uint.Parse(num);
                    message += "* uint\n";
                    canHappen = true;
                }
                catch
                {
                
                }

                try
                {
                    long largeNum = long.Parse(num);
                    message += "* long\n";
                    canHappen = true;
                }
                catch
                {
                
                }

                if (canHappen)
                {
                    Console.WriteLine($"{num} can fit in:");
                    Console.WriteLine(message);
                }
                else
                {
                  Console.WriteLine($"{num} can't fit in any type");
                }
            }
        }
    }
