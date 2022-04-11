using System;

namespace _8.DataType_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int ppl = int.Parse(Console.ReadLine());
            int km = int.Parse(Console.ReadLine());


            Console.WriteLine($"Town {town} has population of {ppl} and area {km} square km.");
        }
    }
}
