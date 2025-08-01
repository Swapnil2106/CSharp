using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class ControlFlows
    {
        public void PrintControlFlows()
        {
            // 1. If-Else statement
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
            // 2. Switch statement
            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                default:
                    Console.WriteLine("It's another day!");
                    break;
            }
            // 3. For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For loop iteration: {i}");
            }
            // 4. While loop
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"While loop iteration: {j}");
                j++;
            }
            // 5. Do-While loop
            int k = 0;
            do
            {
                Console.WriteLine($"Do-While loop iteration: {k}");
                k++;
            } while (k < 5);
        }
    }
}
