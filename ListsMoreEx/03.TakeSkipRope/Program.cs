using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<string> symbols = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                bool isDigit = int.TryParse(input[i].ToString(), out int result);
                if(isDigit)
                {
                    numbers.Add(result);
                }
                else
                {
                    symbols.Add(input[i].ToString());
                }
            }
            List<int> takeList = new List<int>(numbers.Count / 2);
            List<int> skipList = new List<int>(numbers.Count / 2);

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i%2==0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            List<string> message = new List<string>(symbols.Count);
            for (int i = 0; i < Math.Max(takeList.Count,skipList.Count); i++)
            {
                int take = takeList[i];
                if(symbols.Count==0)
                {
                    break;
                }
                if (take>0)
                {
                    if(take>=symbols.Count)
                    {
                        take = symbols.Count;
                    }
                    for (int j = 0; j < take; j++)
                    {
                        message.Add(symbols[0]);
                        symbols.RemoveAt(0);
                    }
                }
                int skip = skipList[i];
                if(skip>0)
                {
                    if(skip>=symbols.Count)
                    {
                        skip = symbols.Count;
                    }
                    for (int k = 0; k < skip; k++)
                    {
                        symbols.RemoveAt(0);
                    }
                }
            }
            Console.WriteLine(String.Join("",message));
            

        }

    }
} 

