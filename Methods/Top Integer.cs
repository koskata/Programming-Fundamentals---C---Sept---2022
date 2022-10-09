using System;
using System.Linq;

namespace _10._Top_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            PrintTopInt(end);
        }


        static void PrintTopInt(int endP)
        {
            for (int i = 0; i < endP; i++)
            {
                if (DivisibleBy8(i) && AtLeastOneDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool DivisibleBy8(int endP)
        {
            int sum = 0;

            while (endP > 0)
            {
                sum += endP % 10;
                endP /= 10;

            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool AtLeastOneDigit(int endP)
        {
            while (endP > 0)
            {
                if ((endP % 10) % 2 == 1)
                {
                    
                    return true;
                    
                }
                endP /= 10;
            }
            return false;
        }
    }
}