using ClassLibrary;
using System;

namespace ConsoleApp1
{
    class Simplecal
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int result;

            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation: ");
            string op = Console.ReadLine();

            Calculator calc = new Calculator();
            if (op == "+")
            {
                result = calc.Add(a, b);
                Console.WriteLine("Result: " + result);
            }
            else if (op == "-")
            {
                result = calc.Sub(a, b);
                Console.WriteLine("Result: " + result);
            }
            else if (op == "*")
            {
                result = calc.Multiply(a, b);
                Console.WriteLine("Result: " + result);
            }
            else if (op == "/")
            {
                result = calc.Divide(a, b);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }
    }
}
