using System;
using System.Linq;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();


            bool isLength = isEnoughLength(inputPassword);
            bool isContain = isContainOnlyLettersAndDigits(inputPassword);
            bool isTwoDigits = hasTwoDigits(inputPassword);

            if (!isLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isContain)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLength && isContain && isTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool isEnoughLength(string password)
        {
            bool isLength = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                isLength = true;
            }

            return isLength;
        }

        static bool isContainOnlyLettersAndDigits(string password)
        {
            bool isContaining = true;

            foreach (char letter in password)
            {
                if (!Char.IsLetterOrDigit(letter))
                {
                    isContaining = false;
                }
            }

            return isContaining;
        }

        static bool hasTwoDigits(string password)
        {
            bool hasTwoDigits = false;
            int counterDigits = 0;

            foreach (char letter in password)
            {
                if (Char.IsDigit(letter))
                {
                    counterDigits++;
                }

            }

            if (counterDigits >= 2)
            {
                hasTwoDigits = true;
            }

            return hasTwoDigits;

            
        }
    }
}