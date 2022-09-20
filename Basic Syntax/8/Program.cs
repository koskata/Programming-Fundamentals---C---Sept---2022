using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                    for (int j = 0; j < counter; j++)
                    {
                        Console.Write($"{i} ");
                    }
                Console.WriteLine($"{i} ");
                counter++;
            }
        }
    }
}