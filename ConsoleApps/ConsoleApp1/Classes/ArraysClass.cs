using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class ArraysClass
    {
        public void PrintArrayExamples()
        {
            // 1. Declare and initialize an array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array: " + string.Join(", ", numbers));

            // 2. Access elements in an array
            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Second element: " + numbers[1]);

            // 3. Modify elements in an array
            numbers[0] = 10;
            Console.WriteLine("Modified first element: " + numbers[0]);

            // 4. Iterate through an array using a for loop
            Console.WriteLine("Iterating through the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            // 5. Iterate through an array using a foreach loop
            Console.WriteLine("Using foreach loop:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // 6. Multidimensional array
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("Multidimensional Array:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 7. Jagged array
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            Console.WriteLine("Jagged Array:");
            foreach (var subArray in jaggedArray)
            {
                Console.WriteLine(string.Join(", ", subArray));
            }

            // 8. Passing arrays to functions
            int[] arrayToPass = { 10, 20, 30 };
            PrintArray(arrayToPass);
        }

        void PrintArray(int[] arr)
        {
            Console.WriteLine("Array passed to function: " + string.Join(", ", arr));
        }
    }
}
