using System;

namespace _2.DataType_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sum = 0;
            int currentNum = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                if (i == 0)
                {
                    currentNum = int.Parse(num);
                }
                sum += currentNum % 10;
                currentNum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
