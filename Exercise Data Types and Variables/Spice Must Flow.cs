using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger startingYield = BigInteger.Parse(Console.ReadLine());

            BigInteger countDays = 0;
            BigInteger sum = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(countDays);
                Console.WriteLine(sum);
            }

            else
            {
                while (startingYield >= 100)
                {

                    BigInteger currrYield = startingYield - 26;

                    sum += currrYield;
                    startingYield -= 10;
                    countDays++;
                }

                sum -= 26;
                Console.WriteLine(countDays);
                Console.WriteLine(sum);
            }
            
        }
    }
}