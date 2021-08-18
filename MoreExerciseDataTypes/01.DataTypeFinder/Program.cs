using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while (true)
            {
                command = Console.ReadLine();
                if(command=="END")
                {
                    break;
                }
                string dataType = string.Empty;
                if (int.TryParse(command,out int result1))
                {
                    dataType = "integer type";
                    Console.WriteLine($"{command} is {dataType}");
                }
                else if(float.TryParse(command,out float result2))
                {
                    dataType = "floating point type";
                    Console.WriteLine($"{command} is {dataType}");
                }
                else if(char.TryParse(command, out char result3))
                {
                    dataType = "character type";
                    Console.WriteLine($"{command} is {dataType}");
                }
                else if(bool.TryParse(command, out bool result4))
                {
                    dataType = "boolean type";
                    Console.WriteLine($"{command} is {dataType}");
                }
                else
                {
                    dataType = "string type";
                    Console.WriteLine($"{command} is {dataType}");
                }
                
               
            }
        }
      
    }
}
