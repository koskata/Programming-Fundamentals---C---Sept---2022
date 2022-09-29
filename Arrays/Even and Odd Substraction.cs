using System;
using System.Linq;

namespace _6._Even_and_Odd_Substraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (currNum % 2 == 0)
                {
                    sumEven += currNum;
                }
                else
                {
                    sumOdd += currNum;
                }

            }
            result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}