using System;

namespace _14.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digitCounter = -1;
            
            int combo = 0;
            string[] message = new string[n]; 
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int digit = 0;
                while (number>0)
                {
                    digit = number % 10;
                    number /= 10;
                    digitCounter++;
                }
                if (digit == 0)
                {
                    message[i] = " ";
                }
               else  if (digit > 1 && digit < 8)
                {
                    combo = 97 + digitCounter + ((digit - 2) * 3);
                    char letter = (char)combo;
                    message[i] = letter.ToString();
                }
               else  if(digit==8 || digit==9)
                {
                    combo = 97 + digitCounter + ((digit - 2) * 3) + 1;
                    char letter = (char)combo;
                    message[i] = letter.ToString();
                }
               
                digitCounter = -1;
            }
            foreach (var item in message)
            {
                Console.Write(item.ToString());
            }
        }
        
    }
}
