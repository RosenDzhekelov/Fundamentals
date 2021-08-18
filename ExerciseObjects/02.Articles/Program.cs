using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articles = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int n = int.Parse(Console.ReadLine());
            Article article = new Article();
            article.Author = articles[2];
            article.Content = articles[1];
            article.Title = articles[0];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                List<string> inputArgs = input
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = inputArgs[0];
                string text = inputArgs[1];
                if (command == "Edit")
                {
                    article.Content = article.Edit(text);
                }
                else if (command == "ChangeAuthor")
                {
                    article.Author = article.Edit(text);
                }
                else if (command == "Rename")
                {
                    article.Title=article.Edit(text);
                }
            }

            string output = article.ToString(article.Title, article.Content, article.Author);
            Console.WriteLine(output);
        }
    }

    public class Article
    {
        public string Edit(string newTitle)
        {
            return newTitle;
        }
        public string ToString(string title , string content , string author)
        {
            return $"{title} - {content}: {author}";
        }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }


    }
}
    

        

    

