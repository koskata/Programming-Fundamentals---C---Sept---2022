using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Extract_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            // C:\Internal\training-internal\Template.pptx

            string cmdArgs = input[input.Length - 1];

            string[] file = cmdArgs.Split('.');
            string fileName = file[0];
            string fileMap = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileMap}");
        }
    }
}