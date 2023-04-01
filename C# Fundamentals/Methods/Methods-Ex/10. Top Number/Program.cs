using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
            
                TopNumber(n);
            }
            static void TopNumber(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    int numCopy = i;
                    int sum = 0;
                    bool oddCount = false;
                    while (numCopy != 0)
                    {
                        sum += numCopy % 10;
                        if ((numCopy % 10) % 2 != 0)
                        {
                            oddCount = true;
                        }
                        numCopy /= 10;
                    }
                    if (oddCount && sum % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
   //        int number = int.Parse(Console.ReadLine());
   //
   //        TopNumber(number);
   //    
   //
   //        static void TopNumber(int number)
   //       {
   //        for (int i = 1; i <= number; i++)
   //        {
   //            bool oddDigit = false;
   //            int copyNumber = i;
   //            int sum = 0;
   //            while (copyNumber != 0)
   //            {
   //                sum += copyNumber % 10;
   //                if ((copyNumber % 10) % 2 != 0)
   //                {
   //                    oddDigit = true;
   //                }
   //                copyNumber /= 10;
   //            }
   //
   //            if (oddDigit && sum % 8 == 0)
   //            {
   //                Console.WriteLine(i);
   //            }
   //        }
   //    }
   }
        
            
            
            
            
            
        
        
            
        
    }
}
