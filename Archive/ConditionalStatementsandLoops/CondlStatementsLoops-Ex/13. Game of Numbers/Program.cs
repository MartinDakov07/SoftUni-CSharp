using System;

namespace _13._Game_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int comb1 = -1;
            int comb2 = -1;           
            int count = 0;

            for(int i = num1; i <= num2; i++)
            {
                for(int j = num1; j <= num2; j++)
                {
                    count++;
                    if(j+i == magicNum)
                    {
                        comb1 = i;
                        comb2 = j;
                    } 
                }
            }
            if(comb1 >=0 && comb2 >= 0)
            {
                Console.WriteLine($"Number found! {comb1} + {comb2} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
