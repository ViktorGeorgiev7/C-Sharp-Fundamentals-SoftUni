using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Objects_Classes_Exercise
{
    internal class Program
    {
        class Person
        {
            public Person(string name, string iD, int age)
            {
                this.Name = name;
                this.ID = iD;
                this.Age = age;
            }

            private string Name { get; set; }

            private string ID { get; set; }

            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command = Console.ReadLine();

            while (command != "End")
            {

                string[] parts = command.Split(' ');
                string name = parts[0];
                string iD = parts[1];
                int age = int.Parse(parts[2]);

                Person currPerson = new Person(name, iD, age);
                people.Add(currPerson);


                command = Console.ReadLine();
            }
            people = people.OrderBy(a => a.Age).ToList();


            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

        }
    }
}

