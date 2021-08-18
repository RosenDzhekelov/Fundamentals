using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder product = new StringBuilder();
            bool isEqual = false;
            for (int i = 0; i < input.Length - 1; i++)
            {
                product.Append(input[i]);
                for (int j = i + 1; j < input.Length; j++)
                {
                    if(input[i]!=input[j])
                    {
                        isEqual = false;
                        if(j==input.Length-1)
                        {
                            product.Append(input[j]);
                        }
                        i = j - 1;
                        break;
                    }
                    else 
                    {
                        isEqual = true;
                    }
                }
                if(isEqual)
                {
                    break;
                }
                
            }
            Console.WriteLine(product);
        }
    }
}
