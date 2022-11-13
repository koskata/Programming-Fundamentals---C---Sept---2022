using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');

            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    Console.Write(string.Concat(strings[i]));
                }
            }
        }
    }
}