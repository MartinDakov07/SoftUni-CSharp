using System;

namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Плодовете "fruit" имат следните възможни стойности: banana, apple, kiwi, cherry, lemon и grapes

            //  Зеленчуците "vegetable" имат следните възможни стойности: tomato, cucumber, pepper и carrot

            //  Всички останали са "unknown"
            string product = Console.ReadLine();
            switch (product)
            {
                case "banana":
                    
                case "apple":
                    
                case "kiwi":
                    
                case "cherry":
                   
                case "lemon":
 
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "pepper":

                case "tomato":

                case "cucumber":

                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
