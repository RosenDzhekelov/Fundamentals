using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            VowelsCount(text);
        }

        static void VowelsCount(string text)
        {
            int vowelCount = 0;
            
             
            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                bool isVowel = "aeiouAEIOU".IndexOf(character) >= 0;
                if (isVowel)
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount); 
        }
    }
}
