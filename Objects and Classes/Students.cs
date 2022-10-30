using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace _4._Students
{
    internal class Students
    {
        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(' ');

                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string homeTown = cmdArgs[3];

                Student st = new Student(firstName, lastName, age, homeTown);

                list.Add(st);
            }

            string town = Console.ReadLine();

            foreach (Student st in list)
            {
                if (st.HomeTown == town)
                {
                    Console.WriteLine($"{st.FirstName} {st.LastName} is {st.Age} years old.");
                }
            }

        }

        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string HomeTown { get; set; }

            public Student(string first, string last, int age, string home)
            {
                FirstName = first;
                LastName = last;
                Age = age;
                HomeTown = home;
            }

        }
    }
}