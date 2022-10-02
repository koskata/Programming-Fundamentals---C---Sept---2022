using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isFound = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        isFound = false;
                        break;
                    }

                }

                if (isFound)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}