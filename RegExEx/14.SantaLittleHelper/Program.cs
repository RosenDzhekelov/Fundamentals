using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _14.SantaLittleHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string pattern = @"@(?<name>[A-Z][a-zA-Z]+)[^@\-!:>]+!(?<behaviour>[GN])!";
            while (input != "end")
            {
                StringBuilder encrypted = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    encrypted.Append((char)(input[i] - key));
                }
                
                if (Regex.IsMatch(encrypted.ToString(), pattern))
                {
                    var child = Regex.Match(encrypted.ToString(), pattern);
                    if (child.Groups["behaviour"].Value == "G")
                    {
                        Console.WriteLine(child.Groups["name"].Value);
                    }

                }

                input = Console.ReadLine();
            }
        }
    }
}

