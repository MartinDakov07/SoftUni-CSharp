using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] currArticle = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            var article = new Article(currArticle[0], currArticle[1], currArticle[2]);
            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
                string command = lines[0];
                string argument = lines[1];
                if(command == "Edit")
                {
                    article.Edit(argument);
                }
                else if(command == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
                else if (command == "Rename")
                {
                    article.Rename(argument);
                }
            }
            Console.WriteLine(article);
            

        }
    }
    public class Article
    {
        public Article (string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Rename(string title) => Title = title;
        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
