﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSentences = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random random = new Random();
            for(int i = 0; i < numOfSentences; i++)
            {
                int phraseInd = random.Next(0, phrases.Length);
                int eventsInd = random.Next(0, events.Length);
                int authorsInd = random.Next(0, authors.Length);
                int citiesInd = random.Next(0, cities.Length);
                Console.WriteLine($"{phrases[phraseInd]} {events[eventsInd]} {authors[authorsInd]} – {cities[citiesInd]}.");
            }
        }
    }
    
}
