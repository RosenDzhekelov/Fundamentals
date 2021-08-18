using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strength = 0;
            bool isOver = false;
            int range = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>' && i < input.Length - 1)
                {
                    if (int.TryParse(input[i + 1].ToString(), out int number))
                    {
                        range = number + strength;
                    }
                    else
                    {
                        range =strength;
                    }
                    int count = 0;
                    strength = 0;
                    while (count < range && input[i + 1] != '>')
                    {
                        input = input.Remove(i + 1, 1);
                        count++;
                        if (i + 1 >= input.Length)
                        {
                            isOver = true;
                            break;
                        }
                    }
                    if (count < range)
                    {
                        strength = range - count;
                    }
                }
                if (isOver)
                {
                    break;
                }
            }
            Console.WriteLine(input);
        }
    }
}
