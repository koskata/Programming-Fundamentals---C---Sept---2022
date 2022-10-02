using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currNum + numbers[j] == magicNumber)
                    {
                        Console.WriteLine($"{currNum} {numbers[j]}");
                    }
                }
            }


        }
    }
}