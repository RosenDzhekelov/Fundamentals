using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToList();

            List<int> mixedList = new List<int>(firstList.Count + secondList.Count);


            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[secondList.Count-1-i]);
            }
            int firstNum = 0;
            int secondNum = 0;
            if(firstList.Count>secondList.Count)
            {
                firstNum = firstList[firstList.Count - 2];
                secondNum = firstList[firstList.Count - 1];
            }
            else
            {
                firstNum = secondList[0];
                secondNum = secondList[1];
            }
            
            for (int i = 0; i < mixedList.Count; i++)
            {
                if(mixedList[i]<=Math.Min(firstNum,secondNum)||mixedList[i]>=Math.Max(firstNum,secondNum))
                {
                    mixedList.RemoveAt(i);
                    i--;
                }
            }
            mixedList.Sort();
            Console.WriteLine(String.Join(" ",mixedList));
        }
                 
    }
}
