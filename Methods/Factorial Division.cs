using System;
using System.Linq;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numFactorial1 = double.Parse(Console.ReadLine());
            double numFactorial2 = double.Parse(Console.ReadLine());

            double allSum = AllSum(numFactorial1, numFactorial2);

            Console.WriteLine($"{allSum:f2}");
        }

        static double Factorial1(double numFactorial1P)
        {
            double sum = 1;

            for (double i = numFactorial1P; i >= 1; i--)
            {
                double curr = i;
                sum *= curr;
            }

            return sum;
        }

        static double Factorial2(double numFactorial2P)
        {
            double sum = 1;

            for (double i = numFactorial2P; i >= 1; i--)
            {
                double curr = i;
                sum *= curr;
            }

            return sum;
        }


        static double AllSum(double numFactorial1P, double numFactorial2P)
        {
            double allSum = Factorial1(numFactorial1P) / Factorial2(numFactorial2P);
            return allSum;
        }
    }
}