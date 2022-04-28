using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] placeHolder = command.Split();
                string action = placeHolder[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(placeHolder[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(placeHolder[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == $"RemoveAt")
                {
                    int indexToRemove = int.Parse(placeHolder[1]);
                    numbers.RemoveAt(indexToRemove);
                }
                else if (action == "Insert")
                {
                    int indexToInsertAt = int.Parse(placeHolder[2]);
                    int elementToInsert = int.Parse(placeHolder[1]);
                    numbers.Insert(indexToInsertAt, elementToInsert);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
