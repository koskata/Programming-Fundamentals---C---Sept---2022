using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            //foreach (Match match in matchCollection)
            //{
            //    Console.Write(match.Value + ", ");
            //}


            string[] result = matchCollection.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}