using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "exchange")
                {
                    int num = int.Parse(command[1]);
                    if (num < 0 || num >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else if (numbers.Length > 1)
                    {
                        int temp = 0;
                        for (int i = 0; i <= num; i++)
                        {
                            for (int index = 0; index < numbers.Length - 1; index++)
                            {
                                int j = index + 1;
                                temp = numbers[index];
                                numbers[index] = numbers[j];
                                numbers[j] = temp;
                            }
                        }
                    }


                }
                else if (command[0] == "max")
                {
                    MaxEven(command[1], numbers);
                    MaxOdd(command[1], numbers);

                }

                else if (command[0] == "min")
                {
                    MinEven(command[1], numbers);
                    MinOdd(command[1], numbers);
                }
                else if (command[0] == "first")
                {
                    int num = int.Parse(command[1]);
                    if (num > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (command[2] == "even")
                    {
                        int counter = 0;
                        bool isEven = false;
                        string[] printer = new string[num + 1];
                        int index = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {

                                counter++;
                                if (counter <= num)
                                {
                                    isEven = true;
                                    printer[index] = numbers[i].ToString();
                                    index++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (isEven == true)
                        {
                            Console.WriteLine($"[{String.Join(", ", printer.Where(s => !string.IsNullOrEmpty(s)))}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else if (command[2] == "odd")
                    {
                        int counter = 0;
                        bool isOdd = false;
                        string[] printer = new string[num];
                        int index = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                counter++;
                                if (counter <= num)
                                {
                                    isOdd = true;
                                    printer[index] = numbers[i].ToString();
                                    index++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (isOdd == true)
                        {
                            Console.WriteLine($"[{String.Join(", ", printer.Where(s => !string.IsNullOrEmpty(s)))}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }

                }
                else if (command[0] == "last")
                {
                    int num = int.Parse(command[1]);
                    if (num > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (command[2] == "even")
                    {
                        int counter = 0;
                        bool isEven = false;
                        string[] printer = new string[num];
                        int index = 0;
                        for (int i = numbers.Length - 1; i >= 0; i--)
                        {
                            if (numbers[i] % 2 == 0)
                            {

                                counter++;
                                if (counter <= num)
                                {
                                    isEven = true;
                                    printer[printer.Length - index - 1] = numbers[i].ToString();
                                    index++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (isEven == true)
                        {
                            Console.WriteLine($"[{String.Join(", ", printer.Where(s => !string.IsNullOrEmpty(s)))}]"); 
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else if (command[2] == "odd")
                    {
                        int counter = 0;
                        bool isOdd = false;
                        string[] printer = new string[num + 1];
                        int index = 0;
                        for (int i = numbers.Length - 1; i >= 0; i--)
                        {
                            if (numbers[i] % 2 == 1)
                            {

                                counter++;
                                if (counter <= num)
                                {
                                    isOdd = true;
                                    printer[printer.Length - index - 1] = numbers[i].ToString();
                                    index++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (isOdd == true)
                        {

                            Console.WriteLine($"[{ String.Join(", ", printer.Where(s => !string.IsNullOrEmpty(s)))}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                }
            }
            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }






        static void MaxEven(string command, int[] numbers)
        {
            if (command == "even")
            {
                int maxEvenIndex = -1;
                int maxEvenValue = int.MinValue;
                bool isBigger = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= maxEvenValue)
                        {
                            maxEvenValue = numbers[i];
                            maxEvenIndex = i;
                            isBigger = true;
                        }
                    }
                }
                if (isBigger)
                {
                    Console.WriteLine(maxEvenIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }
        static void MaxOdd(string command, int[] numbers)
        {
            if (command == "odd")
            {
                int maxOddIndex = -1;
                int maxOddValue = int.MinValue;
                bool isBigger = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        if (numbers[i] >= maxOddValue)
                        {
                            maxOddValue = numbers[i];
                            maxOddIndex = i;
                            isBigger = true;
                        }
                    }
                }
                if (isBigger)
                {
                    Console.WriteLine(maxOddIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void MinOdd(string command, int[] numbers)
        {
            if (command == "odd")
            {
                int minOddIndex = numbers.Length + 1;
                int minOddValue = int.MaxValue;
                bool isSmaller = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        if (numbers[i] <= minOddValue)
                        {
                            minOddValue = numbers[i];
                            minOddIndex = i;
                            isSmaller = true;
                        }
                    }
                }
                if (isSmaller)
                {
                    Console.WriteLine(minOddIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }
        static void MinEven(string command, int[] numbers)
        {
            if (command == "even")
            {
                int minEvenIndex = numbers.Length + 1;
                int minEvenValue = int.MaxValue;
                bool isSmaller = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] <= minEvenValue)
                        {
                            minEvenValue = numbers[i];
                            minEvenIndex = i;
                            isSmaller = true;
                        }
                    }
                }
                if (isSmaller)
                {
                    Console.WriteLine(minEvenIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

    }
}