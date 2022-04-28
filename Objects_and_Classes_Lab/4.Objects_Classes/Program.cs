using System;
using System.Collections.Generic;

namespace _4.Objects_Classes
{
    class Students
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Age { get; set; }

        public string HomeTown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Students> students = new List<Students>();

            while (command != "end")
            {
                string[] placeHolders = command.Split();

                string firstName = placeHolders[0];
                string secondName = placeHolders[1];
                string age = placeHolders[2];
                string homeTown = placeHolders[3];

                Students student = new Students()
                {
                    FirstName = firstName,
                    LastName = secondName,
                    Age = age,
                    HomeTown = homeTown

                };


                students.Add(student);
                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (Students scholar in students)
            {
                if (scholar.HomeTown == city)
                {
                    Console.WriteLine($"{scholar.FirstName} {scholar.LastName} is {scholar.Age} years old. ");
                }
            }
        }
    }
}