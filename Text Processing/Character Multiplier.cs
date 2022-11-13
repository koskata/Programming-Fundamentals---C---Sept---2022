using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string str1 = input[0];
            string str2 = input[1];

            int minStr = Math.Min(str1.Length, str2.Length);

            long sum = 0;

            for (int i = 0; i < minStr; i++)
            {
                sum += str1[i] * str2[i];


            }

            int maxStr = Math.Max(str1.Length, str2.Length);

            for (int i = minStr; i < maxStr; i++)
            {
                if (maxStr == str1.Length)
                {
                    sum += str1[i];
                }

                else if (maxStr == str2.Length)
                {
                    sum += str2[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}