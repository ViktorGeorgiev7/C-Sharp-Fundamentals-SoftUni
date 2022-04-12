using System;

namespace _5.DataType_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (char i = (char)start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
