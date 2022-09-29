using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumArr1 = 0;
            int sumArr2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                int currNum1 = array1[i];
                sumArr1 += currNum1;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                int currNum2 = array2[i];
                sumArr2 += currNum2;

                if (array2[i] != array1[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                
            }

            if (sumArr1 == sumArr2)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumArr1}");
            }

        }
    }
}