using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> foods = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string food = Console.ReadLine();

                foods.Add(food);
            }

            foods.Sort();

            for (int i = 0; i < foods.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{foods[i]}");
            }
        }
    }
}