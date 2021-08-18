using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while(true)
            {
                command = Console.ReadLine();
                if(command=="END")
                {
                    break;
                }
                int number = int.Parse(command);
                if(number<0)
                {
                    continue;
                }
                Palindrome(command);
               
            }
        }
        static void Palindrome(string command)
        {
            bool isPalindrome = false;
            if (command.Length == 1)
            {
                isPalindrome = true;
            }
            else
            {
                for (int i = 0; i < command.Length / 2; i++)
                {
                    if (command[i] == command[command.Length - i - 1])
                    {
                        isPalindrome = true;
                        continue;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isPalindrome);
        }
    }
}
