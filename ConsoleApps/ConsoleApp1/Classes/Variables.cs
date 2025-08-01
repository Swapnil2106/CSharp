using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Variables
    {
        // This class demonstrates the declaration and printing of different types of variables in C#
        public void PrintVariables()
        {
            int age = 25; // Integer variable
            float weight = 76.8f; // Float variable. Use f or F as suffix for float literals
            double height = 5.9; // Double variable
            decimal salary = 63636.75m; // Decimal variable. Use m or M as suffix for decimal literals
            char initial = 'S'; // Character variable
            string name = "Swapnil"; // String variable
            bool isEmployee = true; // Boolean variable

            var message = "Hello, this is a message"; //var keyword


            // Printing the variables to the console
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Initial: " + initial);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Is Employee: " + isEmployee);

            Console.WriteLine("Message: " + message);
        }
    }
}
