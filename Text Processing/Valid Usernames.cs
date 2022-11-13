using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            

            foreach (var username in usernames)
            {
                
                if (username.Length > 3 && username.Length <= 16)
                {
                    bool isValid = true;

                    foreach (char currChar in username)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}