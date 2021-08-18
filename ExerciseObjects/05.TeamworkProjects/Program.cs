using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            TeamDB teamDB = new TeamDB();
            List<Team> teams = new List<Team>();
            List<TeamDB> teamsDb = new List<TeamDB>();
           
           
            for (int i = 0; i < teamCount; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string teamName = input[1];
                string teamCreator = input[0];
               
                if ((!teamDB.Name.Contains(teamName)) &&!teamDB.Creator.Contains(teamCreator))
                {
                    teamDB.Name.Add(teamName);
                    teamDB.Creator.Add(teamCreator);
                    Team team = new Team(teamName,teamCreator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
                else if (teamDB.Name.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamDB.Creator.Contains(teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
            }
            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string[] commandArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string memberName = commandArgs[0];
                string teamName = commandArgs[1];

                if (!teamDB.Name.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (!teamDB.Members.Contains(memberName) && !teamDB.Creator.Contains(memberName))
                {
                    teamDB.Members.Add(memberName);
                    int index = teams.FindIndex(x => x.Name == teamName);
                    teams[index].Members.Add(memberName);
                }
                else
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }


                command = Console.ReadLine();

            }
            foreach (var team in teams.Where(x=> x.Members.Count>0).OrderByDescending(x=> x.Members.Count).ThenBy(x=> x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                team.Members.Sort();
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }    
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teams.Where(x=> x.Members.Count==0).OrderBy(x=> x.Name))
            {
                    Console.WriteLine(team.Name);
            }


              
            
        }

    }

    class Team
    {
        
        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> Members;

        public Team(string team , string creator)
        {
            Name = team;
            Creator = creator;
            Members = new List<string>();
        }

    }
    class TeamDB
    {
        public List<string> Name { get; set; }

        public List<string> Creator { get; set; }
        public List<string> Members { get; set; }

        public TeamDB()
        {
            Name = new List<string>();
            Creator = new List<string>();
            Members = new List<string>();
        }

       
    }
}
