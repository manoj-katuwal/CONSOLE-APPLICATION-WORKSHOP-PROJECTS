using System;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a single-dimensional integer array with 5 numbers
            int[] favoriteNumbers = { 42, 7, 15, 3, 21 };

            Console.WriteLine("Original Array:");
            PrintArray(favoriteNumbers);

            // 2. Use Array.Sort() to sort the array in ascending order
            Array.Sort(favoriteNumbers);
            Console.WriteLine("\nAfter Array.Sort() [Ascending]:");
            PrintArray(favoriteNumbers);

            // 3. Use Array.Reverse() to reverse the sorted array (Descending order)
            Array.Reverse(favoriteNumbers);
            Console.WriteLine("\nAfter Array.Reverse() [Descending]:");
            
            // 4. Print each element of the array using a for loop
            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {favoriteNumbers[i]}");
            }

            // 5. Use Array.IndexOf() to find the position of a specific number
            int searchNumber = 15;
            int index = Array.IndexOf(favoriteNumbers, searchNumber);

            Console.WriteLine($"\nPosition (Index) of {searchNumber}: {index}");
        }

        // Helper method to print array elements
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}