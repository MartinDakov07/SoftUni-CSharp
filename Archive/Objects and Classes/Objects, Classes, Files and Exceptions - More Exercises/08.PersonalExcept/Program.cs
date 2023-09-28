using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _08._Personal_Exception
{
    class PersonalException : Exception
    {
        public PersonalException() : base("My first exception is awesome!!!")
        {
            
        }       
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {            
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    if(number < 0)
                    {
                        throw new PersonalException();
                    }
                    Console.WriteLine(number);
                }
            }
            catch(PersonalException errorMessage)
            {
                Console.WriteLine(errorMessage.Message);
                return;
            }
        }
    }
}
