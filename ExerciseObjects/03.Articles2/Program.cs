using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i <n; i++)
            {
                List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                Article article = new Article();
                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];
                articles.Add(article);
            }
            string criteria = Console.ReadLine();
            if(criteria=="title")
            {
                foreach (Article article in articles.OrderBy(x=>x.Title))
                {
                    string output = article.ToString(article.Title, article.Content, article.Author);
                    Console.WriteLine(output);
                }
            }
            else if(criteria=="content")
            {
                foreach (Article article in articles.OrderBy(x => x.Content))
                {
                    string output = article.ToString(article.Title, article.Content, article.Author);
                    Console.WriteLine(output);
                }
            }
            else if(criteria=="author")
            {
                foreach (Article article in articles.OrderBy(x => x.Author))
                {
                    string output = article.ToString(article.Title, article.Content, article.Author);
                    Console.WriteLine(output);
                }
            }
        }
    }

    public class Article
    {
        public string ToString(string title, string content, string author)
        {
            return $"{title} - {content}: {author}";
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        
    }
}
