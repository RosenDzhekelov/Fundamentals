using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = false;
            bool validDigits = false;


            PasswordLengthCheck(password);
            isValid = PasswordSymbolCheck(password, isValid);
            validDigits = PasswordDigitCounter(password, isValid);

            if (validDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isValid == true && validDigits == true && password.Length >= 6 && password.Length <= 10)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static void PasswordLengthCheck(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }
        static bool PasswordSymbolCheck(string password, bool isValid)
        {

            for (int i = 0; i < password.Length; i++)
            {
                char character = password[i];
                if (character >= 65 && character <= 90 || character >= 97 && character <= 122 || character >= 48 && character <= 57)
                {
                    continue;
                }

                else 
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return isValid = false;
                }
            }
            return isValid = true;
        }

        static bool PasswordDigitCounter(string password, bool isValid)
        {

            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char character = password[i];
                if (character >= 48 && character <= 57)
                {
                    digitCounter++; 
                }
            }
            if (digitCounter >= 2)
            {
                return isValid = true;
            }
            else
            {
                return isValid = false;
            }
        }
    }
}

