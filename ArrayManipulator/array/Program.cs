using System;
using System.Linq;

namespace _11_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split(" ").ToArray();

            while (input[0].ToString() != "end")
            {
                if (input[0].ToString() == "exchange")
                {
                    array = ExchangeArray(array, input);
                    // Console.WriteLine(string.Join(" ", array));
                }
                else if (input[0].ToString() == "max")
                {
                    if (MaxEvenOdd(array, input) == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(MaxEvenOdd(array, input));
                    }
                }
                else if (input[0].ToString() == "min")
                {
                    if (MinEvenOdd(array, input) == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(MinEvenOdd(array, input));
                    }
                }
                else if (input[0].ToString() == "first")
                {
                    if (int.Parse(input[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", FirstEvenOdd(array, input, int.Parse(input[1])))}]");
                    }

                }
                else if (input[0].ToString() == "last")
                {
                    if (int.Parse(input[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", LastEvenOdd(array, input, int.Parse(input[1])))}]");
                    }

                }

                Array.Clear(input, 0, input.Length);
                input = Console.ReadLine().Split(" ").ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        static int[] ExchangeArray(int[] array, string[] input)
        {

            int index = int.Parse(input[1]);
            if (index > array.Length - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
            }

            for (int i = 0; i < array.Length - 1 - index; i++)
            {
                int temp = array[array.Length - 1];

                for (int j = 0; j < array.Length - 1; j++)
                {

                    array[array.Length - j - 1] = array[array.Length - j - 2];
                }

                array[0] = temp;
            }

            return array;
        }
        static int MaxEvenOdd(int[] array, string[] input)
        {


            int currentMax = 0;
            int maxIndex = -1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (input[1] == "even")
                {
                    if (array[i] > array[IndexForMinMaxMethods(array, i)] && array[i] > currentMax && array[i] % 2 == 0)
                    {
                        currentMax = array[i];
                        maxIndex = i;
                    }
                    else if (array[IndexForMinMaxMethods(array, i)] >= currentMax && array[IndexForMinMaxMethods(array, i)] % 2 == 0)
                    {
                        currentMax = array[IndexForMinMaxMethods(array, i)];
                        maxIndex = IndexForMinMaxMethods(array, i);
                    }
                }
                else if (input[1] == "odd")
                {
                    if (array[i] > array[IndexForMinMaxMethods(array, i)] && array[i] > currentMax && array[i] % 2 == 1)
                    {
                        currentMax = array[i];
                        maxIndex = i;
                    }
                    else if (array[IndexForMinMaxMethods(array, i)] >= currentMax && array[IndexForMinMaxMethods(array, i)] % 2 == 1)
                    {
                        currentMax = array[IndexForMinMaxMethods(array, i)];
                        maxIndex = IndexForMinMaxMethods(array, i);
                    }
                }
            }

            return maxIndex;
        }
        static int MinEvenOdd(int[] array, string[] input)
        {
            int currentMin = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (input[1] == "even")
                {
                    if (array[i] < array[IndexForMinMaxMethods(array, i)] && array[i] < currentMin && array[i] % 2 == 0)
                    {
                        currentMin = array[i];
                        minIndex = i;
                    }
                    else if (array[IndexForMinMaxMethods(array, i)] <= currentMin && array[IndexForMinMaxMethods(array, i)] % 2 == 0)
                    {
                        currentMin = array[IndexForMinMaxMethods(array, i)];
                        minIndex = IndexForMinMaxMethods(array, i);
                    }
                }
                else if (input[1] == "odd")
                {
                    if (array[i] < array[IndexForMinMaxMethods(array, i)] && array[i] < currentMin && array[i] % 2 == 1)
                    {
                        currentMin = array[i];
                        minIndex = i;
                    }
                    else if (array[IndexForMinMaxMethods(array, i)] <= currentMin && array[IndexForMinMaxMethods(array, i)] % 2 == 1)
                    {
                        currentMin = array[IndexForMinMaxMethods(array, i)];
                        minIndex = IndexForMinMaxMethods(array, i);
                    }
                }
            }

            return minIndex;
        }
        static string[] FirstEvenOdd(int[] array, string[] input, int n)
        {
            string[] arrayForFailure = { "fail" };
            int counter = 0;
            string result = string.Empty;

            for (int k = 0; k < array.Length; k++)
            {
                if (input[2] == "even")
                {
                    if (array[IndexForMinMaxMethods(array, k - 1)] % 2 == 0)
                    {
                        counter++;
                        result += array[IndexForMinMaxMethods(array, k - 1)].ToString() + ",";
                    }
                }
                else if (input[2] == "odd")
                {
                    if (array[IndexForMinMaxMethods(array, k - 1)] % 2 == 1)
                    {
                        counter++;
                        result += array[IndexForMinMaxMethods(array, k - 1)].ToString() + ",";
                    }
                }

                string[] tempArray = result.Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (counter == n)
                {
                    return tempArray;
                }
                else if (k == array.Length - 1 && counter > 0)
                {
                    return tempArray;
                }
                else if (counter == 0 && k == array.Length - 1)
                {
                    return tempArray;
                }
            }

            return arrayForFailure;
        }
        static string[] LastEvenOdd(int[] array, string[] input, int n)
        {
            string[] arrayForFailure = { "fail" };
            int counter = 0;
            string result = string.Empty;

            for (int k = array.Length - 1; k >= 0; k--)
            {
                if (input[2] == "even")
                {
                    if (array[IndexForMinMaxMethods(array, k - 1)] % 2 == 0)
                    {
                        counter++;
                        result += array[IndexForMinMaxMethods(array, k - 1)].ToString() + ",";
                    }
                }
                else if (input[2] == "odd")
                {
                    if (array[IndexForMinMaxMethods(array, k - 1)] % 2 == 1)
                    {
                        counter++;
                        result += array[IndexForMinMaxMethods(array, k - 1)].ToString() + ",";
                    }
                }

                string[] tempArray = result.Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (counter == n)
                {
                    //Array.Reverse(tempArray);
                    tempArray = ReverseArray(tempArray);
                    return tempArray;
                }
                else if (k == 0 && counter > 0)
                {
                    //Array.Reverse(tempArray);
                    tempArray = ReverseArray(tempArray);
                    return tempArray;
                }
                else if (counter == 0 && k == 0)
                {
                    //Array.Reverse(tempArray);
                    tempArray = ReverseArray(tempArray);
                    return tempArray;
                }
            }

            return arrayForFailure;
        }

        static string[] ReverseArray(string[] reversedArray)
        {
            for (int i = 0; i < reversedArray.Length / 2; i++)
            {
                string temp = reversedArray[i];
                reversedArray[i] = reversedArray[reversedArray.Length - 1 - i];
                reversedArray[reversedArray.Length - 1 - i] = temp;
            }

            return reversedArray;
        }

        static int IndexForMinMaxMethods(int[] array, int i)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                return j;
            }
            return -1;
        }

    }
}
