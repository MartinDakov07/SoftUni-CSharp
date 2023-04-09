using System;
using System.Collections.Generic;
namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ");
                var article = new Article(currArticle[0], currArticle[1], currArticle[2]);
                articles.Add(article);
            }
            string line = Console.ReadLine();
            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }

        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
    

