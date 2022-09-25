using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int endingNum = int.Parse(Console.ReadLine());

            for (int i = startingNum; i <= endingNum; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
        }
    }
}