using System;
using System.Linq;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SmallestNumber();

        }

        static int SmallestNumber()
        {
            int minNum = int.MaxValue;
            for (int i = 1; i <= 3; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                

                if (numbers < minNum)
                {
                    minNum = numbers;
                }
            }

            Console.WriteLine(minNum);
            return minNum;
            
        }
    }
}