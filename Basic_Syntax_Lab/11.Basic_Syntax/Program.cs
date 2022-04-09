using System;

namespace _11.Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());
            if (times > 10)
            {
                Console.WriteLine($"{n} X {times} = {times * n}");

            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {i * n}");
                    times++;
                }
            }
            Console.ReadLine();
        }
    }
}
