using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" -> ");

                string company = cmdArgs[0];
                string id = cmdArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());

                    
                }

                if (!companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }
                

            }

            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}