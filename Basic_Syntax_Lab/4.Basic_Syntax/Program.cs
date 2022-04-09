using System;

namespace _4.Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes > 60)
            {
                minutes -= 60;
                hours++;
            }

            if (hours >= 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}
