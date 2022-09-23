using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int currNumber = i;
                while (currNumber > 0)
                {
                    sum += currNumber % 10;
                    currNumber /= 10;
                }

                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }

            }
        }
    }
}