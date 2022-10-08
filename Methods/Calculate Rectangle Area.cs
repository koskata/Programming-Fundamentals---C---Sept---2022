using System;
using System.Linq;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            GetAreaRectangle(length, width);
        }

        static int GetAreaRectangle(int lengthParam, int widthParam)
        {
            int sum = 0;

            sum = lengthParam * widthParam;

            Console.WriteLine(sum);

            return sum;
        }
    }
}