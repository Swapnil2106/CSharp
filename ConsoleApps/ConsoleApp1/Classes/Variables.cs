using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Variables
    {
        public void PrintVariables()
        {
            int age = 25; // Integer variable
            float weight = 76.8f; // Float variable
            double height = 5.9; // Double variable
            char initial = 'S'; // Character variable
            string name = "Swapnil"; // String variable
            bool isEmployee = true; // Boolean variable
            // Printing the variables to the console
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Initial: " + initial);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Is Employee: " + isEmployee);
        }
    }
}
