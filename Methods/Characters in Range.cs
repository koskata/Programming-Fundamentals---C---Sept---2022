using System;
using System.Linq;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            CharsInRange(symbol1, symbol2);
        }

        static void CharsInRange(char symbol1P, char symbol2P)
        {

            int startCharacter = Math.Min(symbol1P, symbol2P);
            int endCharacter = Math.Max(symbol1P, symbol2P);

            for (int i = startCharacter; i < endCharacter; i++)
            {

                if (i == startCharacter)
                {
                    continue;
                }
                Console.Write($"{(char)i} ");
            }


        }
    }
}