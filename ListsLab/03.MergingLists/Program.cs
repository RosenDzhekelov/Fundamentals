using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
               .Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine()
               .Split().Select(int.Parse).ToList();
            int limit = Math.Min(firstList.Count, secondList.Count);
            List<int> result = new List<int>(firstList.Count + secondList.Count);
            for (int i = 0; i < limit; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if(firstList.Count>secondList.Count)
            {
                result.AddRange(LongerList(secondList, firstList));
            }
            else if(secondList.Count>firstList.Count)
            {
                result.AddRange(LongerList(firstList,secondList));
            }
            Console.WriteLine(String.Join(" ",result));

        }


        private static List<int> LongerList(List<int> shorterList ,List<int> longerList)
        {
            List<int> result = new List<int>(longerList.Count - shorterList.Count);

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }
            return result;
        }
    }
}
