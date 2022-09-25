using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxSum = double.MinValue;
            double sum = 0;
            string maxSumModel = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                sum = (double)(Math.PI * Math.Pow(r, 2) * height);

                if (sum >= maxSum)
                {
                    maxSumModel = model;
                    maxSum = sum;
                }


            }
            Console.WriteLine($"{maxSumModel}");
        }
    }
}