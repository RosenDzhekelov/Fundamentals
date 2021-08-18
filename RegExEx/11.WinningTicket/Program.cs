using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string pattern = @"[@]{6,}|[#]{6,}|[$]{6,}|[\^]{6,10}";
            foreach (var item in input)
            {
                bool isMatch = true;
                string leftHalf = string.Empty;
                string rightHalf = string.Empty;
                if (item.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (i < item.Length / 2)
                        {
                            leftHalf += item[i];
                        }
                        else
                        {
                            rightHalf += item[i];
                        }
                    }
                    if (Regex.IsMatch(leftHalf, pattern) && Regex.IsMatch(rightHalf, pattern))
                    {
                        var leftTicket = Regex.Match(leftHalf, pattern);
                        var rightTicket = Regex.Match(rightHalf, pattern);
                        string firstTicket = leftTicket.ToString();
                        string secondTicket = rightTicket.ToString();
                        if (firstTicket == secondTicket)
                        {
                            if (firstTicket.Length != 10)
                            {
                                Console.WriteLine($"ticket \"{item}\" - {firstTicket.Length}{firstTicket[0]}");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{item}\" - {firstTicket.Length}{firstTicket[0]} Jackpot!");
                            }
                        }
                        else if (firstTicket[0] == secondTicket[0])
                        {
                            int length = Math.Min(firstTicket.Length, secondTicket.Length);
                            Console.WriteLine($"ticket \"{item}\" - {length}{firstTicket[0]}");
                        }
                        else
                        {
                            isMatch = false;
                        }
                    }
                    else
                    {
                        isMatch = false;
                    }
                    if (!isMatch)
                    {
                        Console.WriteLine($"ticket \"{item}\" - no match");
                    }
                }
            }
        }

    }
}
