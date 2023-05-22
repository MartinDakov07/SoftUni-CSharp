using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics.Tracing;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] commandArg = input.Split();
                string command = commandArg[0];
                if(command == "exchange")
                {
                    int index = int.Parse(commandArg[1]);
                    if(index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        numbers = ExchangeArray(numbers, index);
                    }
                }
                else if(command == "max")
                {
                    string evenOrOdd = commandArg[1];
                    
                    if(evenOrOdd == "even")
                    {
                        int index = GetIndexEven(numbers);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if(evenOrOdd == "odd")
                    {
                        int index = GetIndexOdd(numbers);
                        if(index == -1)
                        {
                            Console.WriteLine("No matches");
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }
                else if(command == "min")
                {
                    string evenOrOdd = commandArg[1];

                    if (evenOrOdd == "even")
                    {
                        int index = GetMinIndexEven(numbers);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if (evenOrOdd == "odd")
                    {
                        int index = GetMinIndexOdd(numbers);
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }
                else if(command == "first")
                {
                    int count = int.Parse(commandArg[1]);
                    string evenOrOdd = commandArg[2];
                    if(count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }
                    int[] copyNum = GetEvenOrOddNums(numbers, count, evenOrOdd);
                    PrintResult(copyNum);
                }
                else if(command == "last")
                {
                    int count = int.Parse(commandArg[1]);
                    string evenOrOdd = commandArg[2];
                    if(count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }
                    int[] copyNums = GetEvenOrOddNumsLast(numbers, count, evenOrOdd);
                    PrintResult(copyNums);
                }
                input = Console.ReadLine();
            }
            PrintResult(numbers);

        }
        static int[] ExchangeArray(int[] numbers,int index)
        {
            int[] modifiedArr = new int[numbers.Length];
            int modifiedArrCount = 0;
            for(int i = index + 1; i < numbers.Length; i++)
            {
                modifiedArr[modifiedArrCount++] = numbers[i];                
            }
            for(int i = 0; i <= index;i++)
            {
                modifiedArr[modifiedArrCount++] = numbers[i];
            }
            return modifiedArr;
        }
        static int GetMinIndexEven(int[] numbers)
        {
            int bestIndex = -1;
            int bestEven = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= bestEven)
                    {
                        bestEven = numbers[i];
                        bestIndex = i;
                    }
                }
            }
            return bestIndex;
        }
        static int GetMinIndexOdd(int[] numbers)
        {
            int bestIndex = -1;
            int bestOdd = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] <= bestOdd)
                    {
                        bestOdd = numbers[i];
                        bestIndex = i;
                    }
                }
            }
            return bestIndex;
        }
        static int GetIndexEven(int[] numbers)
        {
            int bestIndex = -1;
            int bestEven = int.MinValue;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= bestEven)
                    {
                        bestEven = numbers[i];
                        bestIndex = i;
                    }
                }
            }
            return bestIndex;
        }
        static int GetIndexOdd(int[] numbers)
        {
            int bestIndex = -1;
            int bestOdd = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] >= bestOdd)
                    {
                        bestOdd = numbers[i];
                        bestIndex = i;
                    }
                }
            }
            return bestIndex;
        }
        static int[] GetEvenOrOddNums(int[] numbers, int count, string evenOrOdd)
        {
            int[] modNum = new int[count];
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter >= modNum.Length)
                {
                    break;
                }
                if (numbers[i] % 2 == 0 && evenOrOdd == "even")
                {
                    modNum[counter++] = numbers[i];
                }
                else if (numbers[i] % 2 != 0 && evenOrOdd == "odd")
                {
                    modNum[counter++] = numbers[i];
                }
            }
            modNum = ResizeArray(modNum, counter);
            return modNum;
        }  
        static int[] GetEvenOrOddNumsLast(int[] numbers, int count,string evenOrOdd)
        {
            int[] modNum = new int[count];
            int counter = 0;
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                if (counter >= modNum.Length)
                {
                    break;
                }
                if (numbers[i] % 2 == 0 && evenOrOdd == "even")
                {
                    modNum[counter++] = numbers[i];
                }
                else if (numbers[i] % 2 != 0 && evenOrOdd == "odd")
                {
                    modNum[counter++] = numbers[i];
                }
            }
            modNum = ResizeArray(modNum, counter);
            modNum = ReverseNumArray(modNum);
            return modNum;
        }
        static int[] ResizeArray(int[] numbers,int count)
        {
            int[] modifiedArr = new int[count];
            for(int i = 0;i< count;i++)
            {
                modifiedArr[i] = numbers[i];
            }
            return modifiedArr;
        }
        static int[] ReverseNumArray(int[] numbers)
        {
            int[] copyArray = new int[numbers.Length];
            for(int i = 1; i <= numbers.Length; i++)
            {
                copyArray[i - 1] = numbers[numbers.Length - i];
            }
            return copyArray;
        }
        static void PrintResult(int[] numbers)
        {
            Console.WriteLine($"[{String.Join(", ",numbers)}]");
        }
        //Damn bro i can't believe i just did 300 lines code
        //*proud of myself*
    }
}
