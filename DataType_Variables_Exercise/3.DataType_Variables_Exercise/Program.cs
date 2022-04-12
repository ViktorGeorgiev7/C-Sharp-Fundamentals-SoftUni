using System;

namespace _3.DataType_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double persons = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            int courses = (int)persons / (int)capacity;

            
            if (persons % capacity == 0)
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses + 1);
            }
        }
    }
}
