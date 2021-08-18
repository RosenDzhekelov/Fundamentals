using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, Dictionary<string, int>>();
            var standings = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while(input!="no more time")
            {
                string[] splitter = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string userName = splitter[0];
                string contest = splitter[1];
                int points = int.Parse(splitter[2]);
                
                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    if(!contests[contest].ContainsKey(userName))
                    {
                        contests[contest].Add(userName, points);
                        if (!standings.ContainsKey(userName))
                        {
                            standings.Add(userName, points);
                        }
                        else 
                        {
                            standings[userName] += points;
                        }
                    }
                    else if(contests[contest][userName]<points)
                    {
                        contests[contest][userName] = points;
                        if (standings.ContainsKey(userName))
                        {
                            standings[userName] = points;
                        }
                    }
                }
                else
                {
                    if (!contests[contest].ContainsKey(userName))
                    {
                        contests[contest].Add(userName, points);
                        if (!standings.ContainsKey(userName))
                        {
                            standings.Add(userName, points);
                        }
                      else  
                        {
                            standings[userName] += points;
                        }

                    }
                    else if (contests[contest][userName] < points)
                    {
                        contests[contest][userName] = points;
                        if (standings.ContainsKey(userName))
                        {
                            standings[userName] = points;
                        }
                    }
                }


                input = Console.ReadLine();
            }
            int line = 1;
            foreach (var contest in contests)
            {
                line = 1;
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                foreach (var item in contest.Value.OrderByDescending(x=> x.Value).ThenBy(x=> x.Key))
                {
                    Console.WriteLine($"{line++}. {item.Key} <::> {item.Value}");
                }
            }
            Console.WriteLine("Individual standings: ");
            line = 1;
            foreach (var contestant in standings.OrderByDescending(x=> x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{line++}. {contestant.Key} -> {contestant.Value}");
            }

        }
    }
}
