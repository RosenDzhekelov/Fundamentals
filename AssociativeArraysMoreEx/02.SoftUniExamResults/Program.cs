using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            //input "{username}-{language}-{points}".
            string input = Console.ReadLine();
            var results = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            while(input!="exam finished")
            {
                string[] inputArgs = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                if (inputArgs[1]=="banned")
                {
                    if(results.ContainsKey(name))
                    {
                        results.Remove(name);
                    }
                }
                else
                {
                    string language = inputArgs[1];
                    int points = int.Parse(inputArgs[2]);
                    if(!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 1);
                    }
                    else
                    {
                        submissions[language]++;
                    }
                    if(!results.ContainsKey(name))
                    {
                        results.Add(name, points);
                    }
                    else
                    {
                        if(results[name]<points)
                        {
                            results[name] = points;
                        }    
                    }
                }



                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var result in results.OrderByDescending(x=> x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{result.Key} | {result.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var submission in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }

        }
    }
}
