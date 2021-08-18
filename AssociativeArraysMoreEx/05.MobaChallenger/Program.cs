using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var players = new Dictionary<string, Dictionary<string, int>>();
            while (input != "Season end")
            {
                string[] checker = input.Split();
                if (checker[1] == "->")
                {
                    string[] splitter = input
                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string name = splitter[0];
                    string position = splitter[1];
                    int skill = int.Parse(splitter[2]);
                    if (!players.ContainsKey(name))
                    {
                        players.Add(name, new Dictionary<string, int>());
                        if (!players[name].ContainsKey(position))
                        {
                            players[name].Add(position, skill);
                        }
                        else if (players[name][position] < skill)
                        {
                            players[name][position] = skill;
                        }
                    }
                    else
                    {
                        if (!players[name].ContainsKey(position))
                        {
                            players[name].Add(position, skill);
                        }
                        else if (players[name][position] < skill)
                        {
                            players[name][position] = skill;
                        }
                    }
                }
                else if (checker[1] == "vs")
                {
                    string[] splitter = input
                        .Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstName = splitter[0];
                    string secondName = splitter[1];
                    if(players.ContainsKey(firstName)&&players.ContainsKey(secondName))
                    {
                        List<string> check = new List<string>();
                        foreach (var player in players[firstName])
                        {
                            check.Add(player.Key);
                        }
                        string key = string.Empty;
                        foreach (var player in players)
                        {
                            if (player.Key == secondName)
                            {
                                foreach (var item in player.Value)
                                {
                                    if (check.Contains(item.Key))
                                    {
                                    
                                            key = item.Key;
                                        if (players[secondName][key] > players[firstName][key])
                                        {
                                            players[firstName].Remove(key);
                                            if(players[firstName].Keys.Count==0)
                                            {
                                                players.Remove(firstName);
                                            }
                                            check.Remove(key);
                                        }
                                        else if (players[secondName][key] < players[firstName][key])
                                        {
                                            players[secondName].Remove(key);
                                            if (players[secondName].Keys.Count == 0)
                                            {
                                                players.Remove(secondName);
                                            }
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                               
                            }
                        }
                       
                    }
                }
               

                    input = Console.ReadLine();
            }
            var rankings = new Dictionary<string, int>();
            foreach (var player in players)
            {
                rankings.Add(player.Key, 0);
                foreach (var item in player.Value)
                {
                    rankings[player.Key] += item.Value;
                }

            }
            foreach (var player in rankings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach (var item in players)
                {
                    if (item.Key == player.Key)
                    {
                        foreach (var position in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        {
                            Console.WriteLine($"- {position.Key} <::> {position.Value}");
                        }
                    }
                }
            }
        }
    }
}
