using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            int sum = 0;
            if(text[0].Length>=text[1].Length)
            {
                sum = CharacterMultiplier(text[0], text[1]);
            }
            else
            {
                sum = CharacterMultiplier(text[1], text[0]);
            }
            Console.WriteLine(sum);

        }

        static int CharacterMultiplier(string bigger , string smaller)
        {
            int sum = 0;
            for (int i = 0; i < bigger.Length; i++)
            {
                if(i<smaller.Length)
                {
                    sum += bigger[i] * smaller[i];
                }
                else
                {
                    sum += bigger[i];
                }
            }
            return sum;
        }
    }


}
