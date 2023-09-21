using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _06._Book_Library_Modification
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            List<Book> books = new List<Book>();
            Dictionary<string, DateTime> dates = new Dictionary<string, DateTime>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Book book = new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = decimal.Parse(input[5])
                };
                books.Add(book);
            }
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            library.Books = books;
            foreach (var item in books)
            {
                var title = item.Title;
                var releaseDate = item.ReleaseDate;
                if (!dates.ContainsKey(title))
                {
                    dates.Add(title, releaseDate);
                }
                else
                {
                    dates[title] = releaseDate;
                }
            }
            foreach (var dateTime in dates.OrderBy(x=>x.Value).ThenBy(x=>x.Key))
            {
                var currDate = dateTime.Value.Date;
                if(currDate > date)
                {
                    Console.WriteLine($"{dateTime.Key} -> {currDate:dd.MM.yyyy}");
                }
                
            }
        }
    }
}
