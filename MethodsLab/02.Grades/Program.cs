using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            FromNumberToWord(grade);
        }

        static void FromNumberToWord(double grade)
        {
            string result = string.Empty;
            if(grade>=2.00 && grade<=2.99)
            {
                result = "Fail";
            }
            else if(grade>=3.00 && grade<=3.49)
            {
                result = "Poor";
            }
            else if(grade>=3.5&&grade<=4.49)
            {
                result = "Good";

            }
            else if(grade>=4.5 && grade<=5.49)
            {
                result = "Very good";
            }
            else if(grade>=5.50 && grade<=6.00)
            {
                result = "Excellent";
            }
            Console.WriteLine(result);
        }
    }
}
