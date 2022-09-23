using System;
namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short centuries = short.Parse(Console.ReadLine());

            int years = (int)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            int minutes = (int)(hours * 60);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}