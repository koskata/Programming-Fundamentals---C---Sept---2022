using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumOfAll = SumOfAll(num);
            Console.WriteLine(sumOfAll);
        }

        static int SumOfAll(int numP)
        {


            int sumOfEvens = GetSumOfEvens(numP);
            int sumOfOdds = GetSumOfOdds(numP);

            return Math.Abs(sumOfEvens * sumOfOdds);
        }
        static int GetSumOfEvens(int numP)
        {
            numP = Math.Abs(numP);

            int evenSum = 0;

            while (numP > 0)
            {
                int currNum = Math.Abs(numP % 10);
                if (currNum % 2 == 0)
                {
                    evenSum += Math.Abs(currNum);
                }

                numP /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOdds(int numP)
        {
            numP = Math.Abs(numP);

            int oddSum = 0;

            while (numP > 0)
            {
                int currNum = Math.Abs(numP % 10);
                if (currNum % 2 == 1)
                {
                    oddSum += Math.Abs(currNum);
                }

                numP /= 10;
            }

            return oddSum;
        }

        
    }
}