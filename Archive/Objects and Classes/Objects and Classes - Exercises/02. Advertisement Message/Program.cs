using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Threading;

namespace _02._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] names = new string[]
            {
               "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] towns = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            
            for(int i = 0; i < n; i++)
            {
                int phraseIndex = rnd.Next(0, phrases.Length);
                int eventIndex = rnd.Next(0, events.Length);
                int nameIndex = rnd.Next(0, names.Length);
                int townIdnex = rnd.Next(0, towns.Length);
                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {names[nameIndex]} - {towns[townIdnex]}");
            }
        }
    }
}
