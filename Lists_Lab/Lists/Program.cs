using System;
using System.Linq;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOne = new List<string>();
            listOne.Add("Ivan");
            listOne.Add("Georgi");
            listOne.Add("Teodor");
            Console.WriteLine(listOne[2]);
            Console.WriteLine(string.Join(", ",listOne));
            foreach (string item in listOne)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < listOne.Count; i++)
            {
                Console.Write(listOne[i]+ ", ");
            }


        }
    }
}
