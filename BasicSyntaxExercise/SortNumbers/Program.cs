using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.MinValue;
            int secondNum = 0;
            int thirdNum = int.MaxValue;
            int[] array = new int[3];
            string combination = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
                if(number>=firstNum)
                {
                    firstNum = number;
                }
                if(number<=thirdNum)
                {
                    thirdNum = number;
                }
                
            }
            if((array[0]>=array[1]&&array[0]<=array[2] ) || (array[0]<=array[1] && array[0]>=array[2]))
            {
                secondNum = array[0];
            }
            else if((array[1]>=array[0]&&array[1]<=array[2]) || (array[1] <= array[0] && array[1] >= array[2]))
            {
                secondNum = array[1];
            }
            else
            {
                secondNum = array[2];
            }
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirdNum);

        }
    }
}
