using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
namespace _03._TakeSkip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> mainList = Console.ReadLine().ToList();
            List<int> numbers = new List<int>();
            (mainList, numbers) = ExtractNumbersFromString(mainList);


            List<int> takeNum = new List<int>();
            List<int> skipNum = new List<int>();
            (takeNum, skipNum) = GetOrSkipNumber(numbers);
             
            StringBuilder decryptedMessage = new StringBuilder(); 
            for(int i = 0; i < takeNum.Count; i++)
            {
                for(int j = 0; j < takeNum[i]; j++)
                {
                    if(mainList.Count > 0)
                    {
                        decryptedMessage.Append(mainList[0]);
                        mainList.RemoveAt(0);
                    }
                }
                if(i >= skipNum.Count)
                {
                    break;
                }
                for(int j = 0; j < skipNum[i]; j++)
                {
                    if(mainList.Count > 0) mainList.RemoveAt(0);
                }
            }
            Console.WriteLine(decryptedMessage.ToString());
        }
        static (List<char>, List<int>) ExtractNumbersFromString(List<char> list)
        {
            List<int> numbersList = new List<int>();
            int index = 0;
            while(index < list.Count)
            {
                if(list[index] >= 48 && list[index] <= 57)
                {
                    numbersList.Add(int.Parse(list[index].ToString()));
                    list.RemoveAt(index);
                }
                else
                {
                    index++;
                }
            }
            return (list, numbersList);
        }
        static (List<int> , List<int>) GetOrSkipNumber(List<int> numbers)
        {
            List<int> get = new List<int>();
            List<int> skip = new List<int>();
            
            for(int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    get.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }
            return (get, skip);
        }
    }
}
