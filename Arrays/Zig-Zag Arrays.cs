using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i % 2 == 0)
                    {
                        arr1[i] = numbers[0];
                        arr2[i] = numbers[1];
                        break;
                    }

                    else
                    {
                        arr1[i] = numbers[1];
                        arr2[i] = numbers[0];
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}