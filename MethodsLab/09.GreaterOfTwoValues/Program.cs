using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input=="string")
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                Console.WriteLine(GetMax(firstStr,secondStr));
            }
            else if(input=="char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar,secondChar));
            }
            else if(input=="int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNum,secondNum));
            }
        }

        static string GetMax(string firstStr , string secondStr)
        {
            char firstChar = firstStr[0];
            char secondCHar = secondStr[0];
            if(firstChar>secondCHar)
            {
                return firstStr;
            }
            else
            {
                return secondStr;
            }
            
        }
        static char GetMax(char firstChar , char secondChar)
        {
            if ((int)firstChar > (int)secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        static int GetMax(int firstNum , int secondNum)
        {
            if(firstNum>secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
    }
}
