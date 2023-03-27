using System;
using System.Linq;
namespace _02.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");          
            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int v = 0; v < firstArray.Length; v++)
                {
                    if (secondArray[i] == firstArray[v])
                    {
                        Console.Write($"{secondArray[i]} ");

                    }
                }
            }
            //My project
            //string[] elements = Console.ReadLine()
            //    .Split(" ");
            //
            //string[] elements2 = Console.ReadLine()
            //    .Split(" ");
            //
            //string[] forPrint = new string[elements.Length];
            //    
            //    
            //for (int i = 0; i < elements2.Length; i++)
            //{
            //    for(int j = 0; j < elements.Length; j++)
            //    {
            //        if (elements2[i]== elements[j])
            //        {
            //            Console.Write(String.Join(' '), elements2[i]);
            //        }
            //    }
            //    
            //}


        }
    }
}
