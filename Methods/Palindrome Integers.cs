using System;
using System.Linq;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                bool isIntPalidrome = PalindromeInt(command);
                if (isIntPalidrome)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        static bool PalindromeInt(string command)
        {
            uint number = uint.Parse(command);
            bool result = false;

            if (number >= 0 && number <= 9)
            {
                result = true;
            }
            else
            {
                for (int i = 0; i < command.Length / 2; i++)
                {
                    if (command[i] == command[command.Length - 1])
                    {
                        result = true;
                    }
                    else
                    {
                        break;
                    }

                }
            }

            return result;
            
        }
    }
}