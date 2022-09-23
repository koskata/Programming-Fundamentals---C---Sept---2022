using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: " );
            double length = 0;
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: " );
            double width = 0;
            width = double.Parse(Console.ReadLine());


            
            Console.Write("Height: " );
            double height = 0;
            height = double.Parse(Console.ReadLine());


            double volume = (length * width * height) / 3;

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}