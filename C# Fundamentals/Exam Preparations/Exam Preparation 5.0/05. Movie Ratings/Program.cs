using System;

namespace _05._Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfFilms = int.Parse(Console.ReadLine());
            double highestRating = 0;
            string bestFilm = "";
            string worstFilm = "";
            double lowestRating = int.MaxValue;
            double totalRating = 0;
            for(int i = 0; i < numOfFilms; i++)
            {
                string film = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if(rating > highestRating)
                {
                    highestRating = rating;
                    bestFilm = film;
                }                
                if(rating < lowestRating)
                {
                    lowestRating = rating;
                    worstFilm = film;
                }
                totalRating += rating;
            }
            double average = totalRating / numOfFilms;
            Console.WriteLine($"{bestFilm} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{worstFilm} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
