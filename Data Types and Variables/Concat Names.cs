﻿using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            string symbols = Console.ReadLine();

            Console.WriteLine($"{name}{symbols}{lastName}");
        }
    }
}