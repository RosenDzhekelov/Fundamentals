using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // If it's uppercase you divide the number by the letter's position in the alphabet. 
            //  If it's lowercase you multiply the number with the letter's position in the alphabet. 
            //Then you move to the letter after the number.
            //If it's uppercase you subtract its position from the resulted number.
            //If it's lowercase you add its position to the resulted number.

            List<string> input = Console.ReadLine().Split().ToList();
            
            
            double totalSum = 0;
            
            foreach (var word in input)
            {
                double sum = 0;
                double number = 0;
                int position = 0;
                string result = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]))
                    {
                        int j = i + 1;
                        result += word[i];
                        while (char.IsDigit(word[j]) && j < word.Length)
                        {
                            
                            result += word[j];
                            j++;
                        }
                        number = double.Parse(result);
                        if (i > 0)
                        {
                            if (word[i - 1] >= 97 && word[i - 1] <= 122)
                            {
                                position = word[i - 1] - 96;
                                sum += position * number;
                            }
                            else if (word[i - 1] >= 65 && word[i - 1] <= 90)
                            {
                                position = word[i - 1] - 64;
                                sum += number / position;
                            }
                        }
                        if(j<word.Length)
                        {
                            if (word[j] >= 97 && word[j] <= 122)
                            {
                                position = word[j] - 96;
                                sum += position ;
                            }
                            else if (word[j] >= 65 && word[j] <= 90)
                            {
                                position = word[j] - 64;
                                sum -= position;
                            }
                           
                        }
                        totalSum += sum;
                        break;

                    }
                }
                
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
