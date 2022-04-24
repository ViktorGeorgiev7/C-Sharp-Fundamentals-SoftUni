using System;

namespace _8.Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double result = PrintResult(firstNum, secondNum);
            Console.WriteLine($"{result:f2}");
        }


        static double PrintResult(double firstNum, double secondNum)
        {
            double firstFactorial = firstNum;
            double secondFactorial = secondNum;

            for (int first = 1; first < firstNum; first++)
            {
                firstFactorial *= first;
            }

            for (int second = 1; second < secondNum; second++)
            {
                secondFactorial *= second;
            }

            double result = firstFactorial / secondFactorial;

            return result;
        }
    }
}