using System;

namespace _8.Methods_Lab
{
    class Program
    { 
        static void Main(string[] args)
        {
            double youKnow = double.Parse(Console.ReadLine());
            double repeat = double.Parse(Console.ReadLine());
            double powerResult = MathPower(youKnow, repeat);
            Console.WriteLine(powerResult);
        }

        static double MathPower(double basfe, double repeat)
        {
            double result = 1;
            for (int i = 0; i < repeat; i++)
            {
                result *= basfe;
            }
            return result;

        }
    }
}
