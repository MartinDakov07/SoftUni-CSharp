using System;

namespace _12._Master_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigits(i))
                {
                    Console.WriteLine(i);
                }
            }            
        }
        static bool IsPalindrome(int num)
        {
            int reminder = 0;
            int sum = 0;
            int temp = 0;
            temp = num;
            while(num > 0)
            { //For example lets use 3443
                reminder = num % 10;//1.Get the reminder - its 3 , after that its 4, then 4 again, and then 3
                num = num / 10; //2.Make the number smaller - it becomes 344, then 34, than 3, and finnaly 0 
                sum = sum * 10 + reminder; //Make a sum, which at the end should be equal to the num, on the first the sum is 3(step 1)
                //Then it becomes 34(3(the sum) * 10 = 30 + 4(the reminder), and after the third loop the number is 344(34*10 + 4), and at the end its 3443
                //344*10 + 3 - THATS IT!
            }
            if(temp == sum)
            {
                return true;
            }
            return false;
        }
        static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            int sum = 0;
            foreach(char nums in number)
            {
                int currNum = int.Parse(nums.ToString());
                sum += currNum;
            }
            if(sum % 7 == 0)
            {
                return true;
            }
            return false;
        }
        static bool ContainsEvenDigits(int num)
        {
            string number = num.ToString();
            foreach(char nums in number)
            {
                int currNum = int.Parse(nums.ToString());
                if(currNum % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
