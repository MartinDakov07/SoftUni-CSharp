using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool lengthValid = IsPasswordLengthValid(password);
            bool hasTwoDigits = IsPasswordContainingTwoDigits(password);
            bool onlyLetterAndDigit = IsPasswordNumeric(password);
            if (!lengthValid)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }
            if (!onlyLetterAndDigit)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            
            if (!hasTwoDigits)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }
            
            if(onlyLetterAndDigit && hasTwoDigits && lengthValid)
            {
                Console.WriteLine("Password is valid ");
            }
        }
        static bool IsPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordNumeric(string password)
        {
            foreach(char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false; 
                }
                
            }
            return true;
        }
        static bool IsPasswordContainingTwoDigits(string password)
        {
            int digitCount = 0;
            foreach(char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
            return digitCount >= 2;
        }
            
    }
}
