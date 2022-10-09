using System;
using System.Linq;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int numForSubtract = int.Parse(Console.ReadLine());

            int sum = SumOfAll(num1, num2, numForSubtract);
            Console.WriteLine(sum);
        }

        static int SumOfAll(int num1Param, int num2Param, int numForSubtracting)
        {
            int sum = 0;

            sum = (num1Param + num2Param) - numForSubtracting;

            return sum;
        }
    }
}