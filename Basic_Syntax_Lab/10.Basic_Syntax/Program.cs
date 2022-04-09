using System;

namespace _10.Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = 1;
            while (times <= 10)
            {

                Console.WriteLine($"{n} X {times} = {times * n}");

                times++;
            }
            Console.ReadLine();
        }
    }
}
