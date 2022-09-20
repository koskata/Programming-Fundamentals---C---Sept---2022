using System;
using System.Diagnostics;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;

            int totalTries = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char letter = username[i];
                password += letter;
                
            }

            string newPassword;
            while ((newPassword = Console.ReadLine()) != password)
            {
                totalTries++;
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}