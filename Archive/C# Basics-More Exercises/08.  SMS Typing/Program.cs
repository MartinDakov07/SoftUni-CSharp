using System;

namespace _08.__SMS_Typing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string message = "";
            for(int i = 0; i < count; i++)
            {              
                string number = Console.ReadLine();
                int digit = int.Parse(number[0].ToString());
                int offset = (digit - 2) * 3;
                if(digit == 8 || digit == 9) // Because 7 and 9 have 4 letters
                {
                    offset += 1;
                }
                if(digit == 0)
                {
                    message += " ";
                    continue;
                }
                int index = offset + number.Length - 1;
                message += (char)(index + 97);
            }
            Console.WriteLine(message);
        }
    }
}
