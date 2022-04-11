using System;

namespace _5.DataType_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int nToProcces = i;
                int sum = 0;

                while (nToProcces != 0)
                {
                    int currentDigit = nToProcces % 10;
                    nToProcces /= 10;
                    sum += currentDigit;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
            Console.ReadLine();
        }
    }
}
