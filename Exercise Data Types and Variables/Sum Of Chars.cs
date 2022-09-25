using System;

namespace _04._Sum_Of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char symbols = char.Parse(Console.ReadLine());

                sum += (int)(symbols);
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}