using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Snowballs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxSum = int.MinValue;
            int maxSnSn = 0;
            int maxSnTm = 0;
            int maxSnQu = 0;

            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality); 

                if (snowballValue >= maxSum)
                {
                    maxSnSn = snowballSnow;
                    maxSnTm = snowballTime;
                    maxSnQu = snowballQuality;
                    maxSum = snowballValue;
                }

                if (i == n)
                {
                    break;
                }

                else
                {
                    snowballSnow = int.Parse(Console.ReadLine());
                    snowballTime = int.Parse(Console.ReadLine());
                    snowballQuality = int.Parse(Console.ReadLine());
                }

                snowballValue = 0;
            }
            Console.WriteLine($"{maxSnSn} : {maxSnTm} = {maxSum} ({maxSnQu})");
        }
    }
}