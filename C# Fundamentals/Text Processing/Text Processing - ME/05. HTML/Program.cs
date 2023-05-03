using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</article>");
            string content = Console.ReadLine();
            while(content != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"   {content}");
                Console.WriteLine("</div>");
                content = Console.ReadLine();
            }
            //or...
            //string title = Console.ReadLine();
            //string article = Console.ReadLine();
            //List<string> comments = new List<string>();
            //string input;
            //
            //while ((input = Console.ReadLine()) != "end of comments")
            //    comments.Add(input);
            //
            //Console.WriteLine($"<h1>\n    {title}\n</h1>");
            //Console.WriteLine($"<article>\n    {article}\n</article>");
            //foreach (string comment in comments)
            //    Console.WriteLine($"<div>\n    {comment}\n</div>");
        }
    }
}
