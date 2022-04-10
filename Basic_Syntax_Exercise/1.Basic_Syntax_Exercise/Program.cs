using System;

namespace _1.Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string typeOfPerson = "";

            if (age >= 0 && age <= 2)
                typeOfPerson = "baby";

            else if (age >= 3 && age <= 13)
            {
                typeOfPerson = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                typeOfPerson = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                typeOfPerson = "adult";
            }
            else if (age >= 66)
            {
                typeOfPerson = "elder";
            }

            Console.WriteLine(typeOfPerson);
        }
    }
}
