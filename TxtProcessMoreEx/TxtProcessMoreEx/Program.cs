using System;
using System.Text;

namespace TxtProcessMoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < lines; i++)
            {
                bool isNameFound = false;
                bool isAgeFound = false;
                string input = Console.ReadLine();
                StringBuilder name = new StringBuilder();
                StringBuilder age = new StringBuilder();
                for (int index = 0; index < input.Length; index++)
                {
                    if(input[index]=='@')
                    {
                        int j = index + 1;
                        while(input[j]!='|')
                        {
                            name.Append(input[j]);
                            j++;
                        }
                        index = j;
                        isNameFound = true;
                    }
                    else if(input[index]=='#')
                    {
                        int j = index + 1;
                        while (input[j] != '*')
                        {
                            age.Append(input[j]);
                            j++;
                        }
                        index = j;
                        isAgeFound = true;
                    }
                    if (isNameFound&&isAgeFound)
                    {
                        Console.WriteLine($"{name} is {age} years old.");
                        break;
                    }
                }
                
            }
        }
    }
}
