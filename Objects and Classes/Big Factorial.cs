using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _2._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;

            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                int currNum = i;

                factorial *= currNum;
            }

            Console.WriteLine(factorial);
        }
    }
}