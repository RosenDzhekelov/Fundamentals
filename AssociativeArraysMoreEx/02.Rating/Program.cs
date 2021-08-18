using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            var rankings = new Dictionary<string, Dictionary<string, int>>();
            var contests = new List<Contest>();
            Contest contest = new Contest();
            while (firstInput != "end of contests")
            {
                string[] splitter = firstInput
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                contest = new Contest(splitter[0], splitter[1]);
                contests.Add(contest);
                firstInput = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();
            while (secondInput !="end of submissions")
            {
                string[] splitter = secondInput
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestName = splitter[0];
                string password = splitter[1];
                string userName = splitter[2];
                int points = int.Parse(splitter[3]);

                if (contests.Any(x => x.Name == contestName && x.Password == password))
                {
                    if (!rankings.ContainsKey(userName))
                    {
                        rankings.Add(userName, new Dictionary<string, int>());
                        if (!rankings[userName].ContainsKey(contestName))
                        {
                            rankings[userName].Add(contestName, points);
                        }
                        else
                        {
                            if (rankings[userName][contestName] < points)
                            {
                                rankings[userName][contestName] = points;
                            }
                        }
                    }
                    else
                    {
                        if (!rankings[userName].ContainsKey(contestName))
                        {
                            rankings[userName].Add(contestName, points);
                        }
                        else
                        {
                            if (rankings[userName][contestName] < points)
                            {
                                rankings[userName][contestName] = points;

                            }
                        }
                    }
                }

                secondInput = Console.ReadLine();

            }
            string bestContestant = "";
            int mostPoints = 0;
            int currentPoints = 0;
            foreach (var user in rankings)
            {
                foreach (var item in user.Value)
                {
                    currentPoints += item.Value;
                    if (currentPoints > mostPoints)
                    {
                        mostPoints = currentPoints;
                        bestContestant = user.Key;
                    }
                }
                currentPoints = 0;
            }
            Console.WriteLine($"Best candidate is {bestContestant} with total {mostPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in rankings.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }


        public class Contest
        {
            public string Name { get; set; }
            public string Password { get; set; }


            public Contest(string name, string password)
            {
                Name = name;
                Password = password;
            }
            public Contest()
            {

            }
        }
    }
}






