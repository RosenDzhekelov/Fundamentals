using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersBetweenTwoGive(firstChar, secondChar);
        }

        static void CharactersBetweenTwoGive(char firstChar , char secondChar)
        {
            char character = ' ';
            if(firstChar>secondChar)
            {
                character = secondChar;
                secondChar = firstChar;
                firstChar = character;
                
            }
            for (int i = firstChar+1; i < secondChar; i++)
            {
                character = (char)i;
                Console.Write(character+" ");
            }
        }
    }
}
