using System;
using System.Linq;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            MathPower(number, power);
        }

        static double MathPower(double numParam, double powerParam)
        {
            double sum = 0.0;

            sum = Math.Pow(numParam, powerParam);

            Console.WriteLine(sum);

            return sum;


        }
    }
}