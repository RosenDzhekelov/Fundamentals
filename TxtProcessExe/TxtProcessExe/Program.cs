using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TxtProcessExe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            StringBuilder validNames = new StringBuilder(names.Count);
            bool isValid = false;
            foreach (var name in names)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (char.IsDigit(name[i]) || char.IsLetter(name[i]) || name[i] == 45 || name[i] == 95)
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validNames.AppendLine(name);
                    }
                }
            }
            Console.WriteLine(validNames);
        }
    }
}
