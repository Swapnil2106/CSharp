using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class StringClass
    {
        public void PrintStringMethods()
        {
            string str = "Hello, World!";
            
            // Length of the string
            Console.WriteLine("Length: " + str.Length);
            
            // Convert to uppercase
            Console.WriteLine("Uppercase: " + str.ToUpper());
            
            // Convert to lowercase
            Console.WriteLine("Lowercase: " + str.ToLower());
            
            // Check if the string contains a substring
            Console.WriteLine("Contains 'World': " + str.Contains("World"));
            
            // Replace a substring
            Console.WriteLine("Replace 'World' with 'C#': " + str.Replace("World", "C#"));
            
            // Split the string into an array
            string[] words = str.Split(' ');
            Console.WriteLine("Split: " + string.Join(", ", words));

            // Trim whitespace from both ends
            string trimmedStr = "   Hello, World!   ";
            Console.WriteLine("Trimmed: " + trimmedStr.Trim());

            //Verbatim string literal
            string verbatimStr = @"This is a verbatim string literal.It can span multiple lines and ignores escape sequences like \n or \t.";
            Console.WriteLine("Verbatim String: " + verbatimStr);

            // String interpolation
            string name = "Swapnil";
            int age = 25;
            Console.WriteLine($"Name: {name}, Age: {age}");

            // String concatenation
            string firstName = "Swapnil";
            string lastName = "Kore";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name: " + fullName);

        }
    }
}
