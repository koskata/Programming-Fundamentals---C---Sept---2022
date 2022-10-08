using System;
using System.Linq;

namespace _3._Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Calculations(command, number1, number2);
        }

        static void Calculations(string command, int number1, int number2)
        {
            if (command == "subtract")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (command == "add")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (command == "multiply")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (command == "divide")
            {
                Console.WriteLine(number1 / number2);
            }
        }
    }
}