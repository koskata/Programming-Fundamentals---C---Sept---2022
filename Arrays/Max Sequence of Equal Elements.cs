using System;
using System.Linq;
using System.Reflection;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int counter = 1;
            int winningCounter = 0;
            int number = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                

                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > winningCounter)
                {
                    winningCounter = counter;
                    number = numbers[i];
                }
            }
            for (int i = 1; i <= winningCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}