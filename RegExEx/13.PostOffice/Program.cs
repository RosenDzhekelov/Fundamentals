using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _13.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPattern = @"([#%$*&])(?<letter>[A-Z]+)\1";
            string secondPattern = @"(?<asciiCode>\d+):(?<length>\d{2})";

            string[] input = Console.ReadLine().Split("|");
            var firstLetter = Regex.Match(input[0], firstPattern);
            var foundLetters = Regex.Matches(input[1], secondPattern);
            int checker = 0;
            string validLetters = string.Empty;
            List<Word> words = new List<Word>();
            string validLetter = firstLetter.Groups["letter"].Value.ToString();
            foreach (Match letter in foundLetters)
            {
                checker = int.Parse(letter.Groups["asciiCode"].Value);
                if (firstLetter.ToString().Contains((char)checker) && validLetter.Contains((char)checker))
                {
                    Word word = new Word();
                    word.StartingLetter = (char)checker;
                    word.Length = int.Parse(letter.Groups["length"].Value) + 1;
                    words.Add(word);
                    validLetters += (char)checker;
                }
            }
            string[] unfilteredWords = input[2].Split();

            foreach (var item in unfilteredWords)
            {
                if (validLetters.Contains(item[0]))
                {
                    foreach (var word in words)
                    {
                        if (item[0] == word.StartingLetter && item.Length == word.Length)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }
    }

    class Word
    {
        public char StartingLetter { get; set; }
        public int Length { get; set; }
    }
}