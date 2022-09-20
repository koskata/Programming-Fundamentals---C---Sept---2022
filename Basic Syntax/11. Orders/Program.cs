using System;
using System.Diagnostics;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            double totalSum = 0;

            for (int i = 1; i <= N; i++)
            {
                while (true)
                {
                    sum = 0;
                    double priceForCapsule = double.Parse(Console.ReadLine());
                    int days = int.Parse(Console.ReadLine());
                    int capsulseCount = int.Parse(Console.ReadLine());

                    sum = ((days * capsulseCount) * priceForCapsule);
                    totalSum += sum;
                    Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                    break;
                }
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}