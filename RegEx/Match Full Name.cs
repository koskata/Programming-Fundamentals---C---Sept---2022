using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection result = regex.Matches(input);

            foreach (Match match in result)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}