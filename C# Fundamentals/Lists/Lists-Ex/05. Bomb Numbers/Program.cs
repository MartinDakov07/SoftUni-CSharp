using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine()
            //      .Split()
            //      .Select(int.Parse)
            //      .ToList();
            //int[] dataInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //
            //int bomb = dataInfo[0];
            //int power = dataInfo[1];
            //List<int> newNumbers= DeleteLeftAndRightSide(numbers, bomb, power);
            //if (newNumbers.Contains(bomb))
            //{
            //    numbers.Remove(bomb);
            //}
            //int sum = 0;
            //for(int i = 0; i < newNumbers.Count; i++)
            //{
            //    sum += newNumbers[i];
            //}
            //Console.WriteLine(sum);
            var sequense = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            int indexOfBomb = 0;

            while (sequense.Contains(bomb))
            {
                for (int i = 0; i < sequense.Count; i++)
                {
                    if (sequense[i] == bomb)
                    {
                        indexOfBomb = i;
                        break;
                    }
                    //namirame bombata
                }

                int startIndex = indexOfBomb - power;//otstranqvame vsichko ot lqvo
                int count = 2 * power + 1; // kolko pyti da otsrani ot nachaloto do kraq

                if (startIndex < 0)
                    startIndex = 0;//ako imame po malko ot powera go pravim na 0

                if (count > sequense.Count - 1)
                    count = sequense.Count - startIndex;

                sequense.RemoveRange(startIndex, count);
            }

            Console.WriteLine(sequense.Sum());
        }
        //static List<int> DeleteLeftAndRightSide(List<int> numbers, int bomb, int power)
        //{
        //    //2 3 4 6 7 9 2 3 4 => bomb = 9
        //    if (numbers.Contains(bomb))
        //    {
        //        for(int i = 0; i < numbers.Count; i++)
        //        {
        //            if(numbers[i] == bomb)
        //            {
        //                for(int j = 0; j < power; j++)
        //                {
        //                    numbers.RemoveAt(i - 1);
        //                    i--;
        //                }
        //                break;
        //                
        //            }                 
        //        }
        //    }
        //    if (numbers.Contains(bomb))
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //        {
        //            if (numbers[i] == bomb)
        //            {
        //                //for (int j = 0; j < power; j++)
        //                while(power > 0)
        //                {
        //                    numbers.RemoveAt(i + 1);
        //                    power--;
        //                }
        //                break;
        //
        //            }
        //        }
        //    }
        //    return numbers;
        //}
       
    }
}
