using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            int[] namesValue = new int[n];
            for(int i = 0; i <= names.Length - 1; i++)
            {
                string name = Console.ReadLine();
                int nameValue = 0;
                foreach(char c in name)
                {
                    if(c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'u'|| c == 'A' || c == 'E'|| c == 'O' || c == 'I' || c == 'U')
                        
                    {
                        nameValue += (int)c * name.Length;
                    }
                    else
                    {
                        nameValue += (int)c / name.Length;
                    }                  
                }
                names[i] = name;
                namesValue[i] = nameValue;
            }          
            namesValue = namesValue.OrderBy(x => x).ToArray();
            for(int i = 0; i <= names.Length - 1; i++)
            {
                Console.WriteLine(namesValue[i]);
            }
        }
    }
}
