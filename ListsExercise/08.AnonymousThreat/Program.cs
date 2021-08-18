using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] splitCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (splitCommand[0] == "merge")
                {
                    int startIndex = int.Parse(splitCommand[1]);
                    int endIndex = int.Parse(splitCommand[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        input[startIndex] += input[i];
                    }
                    for (int i = 0; i < endIndex - startIndex; i++)
                    {
                        input.RemoveAt(startIndex + 1);
                    }


                }
                else if (splitCommand[0] == "divide")
                {
                    int index = int.Parse(splitCommand[1]);
                    int partations = int.Parse(splitCommand[2]);
                    string someText = input[index];
                    string sumOfLetters = "";
                    double limit = (double)input[index].Length / partations;
                    int limitIndex = 0;
                    if (someText.Length % partations == 0)
                    {
                        for (int j = 0; j < partations; j++)
                        {
                            for (int i = 0; i < limit; i++)
                            {
                                if (limitIndex < someText.Length)
                                {
                                    sumOfLetters += someText[limitIndex++];
                                }
                                else
                                {
                                    break;
                                }
                            }

                            input.Insert(index + 1 + j, sumOfLetters);
                            sumOfLetters = "";
                        }
                        input.RemoveAt(index);

                    }
                    else
                    {
                        if (limit < 1)
                        {
                            limit = 1;  
                        }
                        double newLimit = Math.Round((double)limit);
                        if(partations>someText.Length)
                        {
                            partations = someText.Length - 1;
                        }
                        
                        if (someText.Length > 2)
                        {
                           
                            for (int j = 0; j <=partations-1; j++)
                            {
                                if(j==partations-1)
                                {
                                    limit+=newLimit;
                                }
                                for (int i = 0; i < Math.Floor(limit); i++)
                                {
                                    if (limitIndex < someText.Length)
                                    {
                                        sumOfLetters += someText[limitIndex++];
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                input.Insert(index + 1 + j, sumOfLetters);
                                sumOfLetters = "";
                            }

                            input.RemoveAt(index);
                        }
                      
                    }
                   
                }
                

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
