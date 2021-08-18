using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[a-zA-Z!-/:-@[-`{-~ ]+[0-9]*";
            string input = Console.ReadLine();
            var letters = Regex.Matches(input, pattern);
            StringBuilder newMessage = new StringBuilder();
            foreach (Match letter in letters)
            {
                string splitLetter = letter.ToString();
                string check = string.Empty;
                if (int.TryParse(splitLetter[splitLetter.Length - 1].ToString(), out int number)
                    && int.TryParse(splitLetter[splitLetter.Length - 2].ToString(), out int num))
                {
                    check = splitLetter[splitLetter.Length - 2].ToString() + splitLetter[splitLetter.Length - 1].ToString();
                    number = int.Parse(check);
                    splitLetter = splitLetter.Remove(splitLetter.Length - 2);
                    for (int i = 0; i < number; i++)
                    {
                        newMessage.Append(splitLetter.ToUpper());
                    }
                }
                else if (int.TryParse(splitLetter[splitLetter.Length - 1].ToString(), out int count))
                {
                    splitLetter = splitLetter.Remove(splitLetter.Length - 1);
                    for (int i = 0; i < count; i++)
                    {
                        newMessage.Append(splitLetter.ToUpper());
                    }
                }
                else
                {
                    newMessage.Append(splitLetter.ToUpper());
                }
            }
            string counter = string.Empty;
            string checker = newMessage.ToString();
            for (int i = 0; i < checker.Length; i++)
            {
                if (!counter.Contains(checker[i]))
                {
                    counter += checker[i];
                }
            }
            Console.WriteLine($"Unique symbols used: {counter.Length}");
            Console.WriteLine(newMessage.ToString());
        }
    }
}
