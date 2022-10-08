using System;
using System.Linq;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            RepeatString(text, n);
        }

        static void RepeatString(string textParam, int nParam)
        {
            for (int i = 0; i < nParam; i++)
            {
                Console.Write($"{textParam}");
            }
        }
    }
}