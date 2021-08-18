using System;

namespace _04.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            arr[0] = 1;
            for (int i = 1; i < num; i++)
            {
                int index = i - 1;
                for (int j = 0; j<3 ; j++)
                {
                    if (index >= 0)
                    {
                        arr[i] += arr[index];
                        index--;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",arr));
           
        }
    }
}
