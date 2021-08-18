using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openBracketCounter = 0;
            int closedBracketCounter = 0;
            int checker = 0;
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                if (char.TryParse(text, out char result))
                {
                    if (result == 40)
                    {
                        openBracketCounter++;
                        checker++;
                        if (checker == 2)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                    else if (result == 41 )
                    {
                        closedBracketCounter++;
                        checker = 0;
                    }
                }
                if(int.TryParse(text, out int num))
                {
                    if(num==40)
                    {
                        openBracketCounter++;
                        checker++;
                        if (checker == 2)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                    else if (num == 41)
                    {
                        closedBracketCounter++;
                        checker = 0;
                    }
                }
            }
            if (openBracketCounter==closedBracketCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
