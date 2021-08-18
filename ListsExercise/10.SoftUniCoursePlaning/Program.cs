using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlaning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            while (true)
            {
                if (input == "course start")
                {
                    break;
                }

                string[] commands = input.Split(':');
                string lessonTitle = commands[1];
                string exercise = lessonTitle + "-Exercise";
                if (commands[0] == "Add")
                {

                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                    }

                }
                else if (commands[0] == "Insert")
                {

                    int index = int.Parse(commands[2]);
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (commands[0] == "Remove")
                {

                    if (schedule.Contains(lessonTitle))
                    {
                        schedule.Remove(lessonTitle);
                    }
                    else if (schedule.Contains(lessonTitle) && schedule.Contains(exercise))
                    {
                        schedule.Remove(lessonTitle);
                        schedule.Remove(exercise);
                    }
                }
                else if (commands[0] == "Swap")
                {
                    string firstLessonTitle = commands[1];
                    string firstExercise = commands[1] + "-Exercise";

                    string secondLessonTitle = commands[2];
                    string secondExercise = commands[2] + "-Exercise";
                    bool isTwoLessons = schedule.Contains(firstLessonTitle) && schedule.Contains(secondLessonTitle);
                    bool isFirstExercise = schedule.Contains(firstExercise);
                    bool isSecondExercise = schedule.Contains(secondExercise);
                    if (isTwoLessons)
                    {
                        if (!isFirstExercise && !isSecondExercise)
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == firstLessonTitle)
                                {
                                    schedule[i] = secondLessonTitle;
                                }
                               else if (schedule[i] == secondLessonTitle)
                                {
                                    schedule[i] = firstLessonTitle;
                                }
                            }
                        }
                        else if (isFirstExercise && !isSecondExercise)
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == firstLessonTitle)
                                {
                                    schedule[i] = secondLessonTitle;
                                    schedule.RemoveAt(i + 1);
                                }
                              else  if (schedule[i] == secondLessonTitle)
                                {
                                    schedule[i] = firstLessonTitle;
                                    schedule.Insert(i + 1, firstExercise);
                                }
                            }
                        }
                        else if (!isFirstExercise && isSecondExercise)
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == firstLessonTitle)
                                {
                                    schedule[i] = secondLessonTitle;
                                    schedule.Insert(i + 1, secondExercise);
                                }
                               else  if (schedule[i] == secondLessonTitle)
                                {
                                    schedule[i] = firstLessonTitle;
                                    schedule.RemoveAt(i + 1);

                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == firstLessonTitle)
                                {
                                    schedule[i] = secondLessonTitle;
                                    schedule.Insert(i + 1, secondExercise);
                                }
                                else  if (schedule[i] == secondLessonTitle)
                                {
                                    schedule[i] = firstLessonTitle;
                                    schedule.Insert(i + 1, firstExercise);
                                }
                            }
                        }
                    }

                }
                else if (commands[0] == "Exercise")
                {

                    if (schedule.Contains(lessonTitle) && (!schedule.Contains(exercise)))
                    {
                        for (int i = 0; i < schedule.Count; i++)
                        {
                            if (schedule[i] == lessonTitle)
                            {
                                schedule.Insert(i + 1, exercise);
                            }
                        }
                    }
                    else if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add(exercise);
                    }
                }


                input = Console.ReadLine();

            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{schedule[i]}");
            }
            
        }
    }
}
