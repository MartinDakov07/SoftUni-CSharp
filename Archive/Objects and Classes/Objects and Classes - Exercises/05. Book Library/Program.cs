using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace _05._Book_Library
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
            public decimal Price { get;set; }
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
            for(int i = 0; i < n; i++)
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
            library.Books = books;
            var orderedBooks = library.Books.GroupBy(x => x.Author)
                                        .Select(g => new
                                        {
                                            Author = g.Key,
                                            Prices = g.Sum(s => s.Price)
                                        })
                                        .OrderByDescending(x => x.Prices)
                                        .ThenBy(x => x.Author)
                                        .ToList();
            foreach(var book in orderedBooks)
            {
                Console.WriteLine($"{book.Author} -> {book.Prices:f2}");
            }
        }
    }
}
