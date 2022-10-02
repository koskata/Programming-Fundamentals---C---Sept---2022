using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currWagon = int.Parse(Console.ReadLine());
                sum += currWagon;
                wagons[i] = currWagon;

                
            }

            Console.WriteLine(string.Join(" ", wagons));

            Console.WriteLine(sum);
        }
    }
}