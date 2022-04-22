using System;

namespace _3.Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
            {
                string action = Console.ReadLine();
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());


                Calculations(action, firstNum, secondNum);
            }

            static void Calculations(string action, int num1, int num2)
            {
                int result = 0;
                switch (action)
                {
                    case "add":
                        result = num1 + num2;
                        break;
                    case "multiply":
                        result = num1 * num2;
                        break;
                    case "subtract":
                        result = num1 - num2;
                        break;
                    case "divide":
                        result = num1 / num2;
                        break;
                }
                Console.WriteLine(result);

            }
        }
    }

