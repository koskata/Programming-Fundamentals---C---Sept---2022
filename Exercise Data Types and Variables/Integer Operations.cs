﻿using System;
using System.Numerics;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            long firstResult = (long)num1 + num2;
            long secondResult = firstResult / num3;
            BigInteger thirdResult = (BigInteger)(secondResult * num4);

            Console.WriteLine(thirdResult);
        }
    }
}