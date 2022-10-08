using System;
using System.Linq;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double sum = 0;

            if (operation == '+')
            {
                sum = GetPlus(num1, operation, num2);
            }
            else if (operation == '-')
            {
                sum = GetMinus(num1, operation, num2);
            }
            else if (operation == '/')
            {
                sum = GetDividing(num1, operation, num2);
            }
            else if (operation == '*')
            {
                sum = GetMultiplaing(num1, operation, num2);
            }

            Console.WriteLine(sum);
        }

        static int GetPlus(int num1P, char operationP, int num2P)
        {
            int sum = 0;

            sum = num1P + num2P;

            return sum;
        }

        static int GetMinus(int num1P, char operationP, int num2P)
        {
            int sum = 0;

            sum = num1P - num2P;

            return sum;
        }

        static double GetDividing(int num1P, char operationP, int num2P)
        {
            double sum = 0;

            sum = num1P / num2P;

            return sum;
        }

        static int GetMultiplaing(int num1P, char operationP, int num2P)
        {
            int sum = 0;

            sum = num1P * num2P;

            return sum;
        }
    }
}