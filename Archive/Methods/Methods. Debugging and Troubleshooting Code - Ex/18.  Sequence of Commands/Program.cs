using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;

namespace _18.__Sequence_of_Commands
{
    internal class Program
    {
        private const char ArgumentsDelimiter = ' ';
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "stop")
            {
                string[] stringParams = command.Split(ArgumentsDelimiter);
                int[] arg = new int[2];
                string commandArg = stringParams[0];
                if (commandArg.Equals("add") ||
                    commandArg.Equals("subtract") ||
                    commandArg.Equals("multiply"))
                {
                    
                    arg[0] = int.Parse(stringParams[1]);
                    arg[1] = int.Parse(stringParams[2]);

                   array = PerformAction(array, commandArg, arg);
                }
                else
                {
                    array = PerformAction(array, commandArg, arg);
                }               

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0]-1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
            return array;
        }

        private static void ArrayShiftRight(long[] array)
        {
            long firstNum = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = firstNum;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long lastNum = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = lastNum;
        }

        private static void PrintArray(long[] array)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}


