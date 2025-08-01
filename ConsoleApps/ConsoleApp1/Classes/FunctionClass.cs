using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class FunctionClass
    {
        public void PrintFunctionExamples()
        {
            // 1. Function without parameters and return type
            PrintHelloWorld();

            // 2. Function with parameters
            int sum = AddNumbers(5, 10);
            Console.WriteLine("Sum: " + sum);

            // 3. Function with return type
            int product = MultiplyNumbers(5, 10);
            Console.WriteLine("Product: " + product);

            // 4. Function with optional parameters
            int result = Calculate1(5, 10, multiplier: 2);
            Console.WriteLine("Result with multiplier: " + result);

            // 5. Function with named arguments
            int namedResult = Calculate2(multiplier: 3, number1: 4, number2: 6);
            Console.WriteLine("Named Result: " + namedResult);
        }

        // Function without parameters and return type
        private void PrintHelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        // Function with parameters
        private int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Function with return type
        private int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        // Function with optional parameters
        private int Calculate1(int number1, int number2, int multiplier = 1)
        {
            return (number1 + number2) * multiplier;
        }

        // Function with named arguments
        private int Calculate2(int number1, int number2, int multiplier)
        {
            return (number1 + number2) * multiplier;
        }
    }
