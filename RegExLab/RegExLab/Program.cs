using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExLab
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string pattern = @"(\b[A-Z][a-z]+ [A-Z][a-z]+\b)";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            var results = regex.Matches(text);
            foreach (Match item in results)
            {
                Console.Write(item.Value+" ");
            }
            Console.WriteLine();
            
        }
    }
}
