using System;
using System.Collections.Generic;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Part 1: List<string> ---
            Console.WriteLine("=== PART 1: List<string> ===");

            // 1. Create a List<string> containing 3 favorite fruits
            List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

            // 2. Add a new fruit to the list
            fruits.Add("Orange");

            // 3. Remove one fruit from the list
            fruits.Remove("Banana");

            // 4. Print all fruits in the list using a foreach loop
            Console.WriteLine("Fruits in the list:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }


            // --- Part 2: Dictionary<int, string> ---
            Console.WriteLine("\n=== PART 2: Dictionary<int, string> ===");

            // 5. Create a Dictionary<int, string> with fruit IDs and names
            Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Mango" }
            };

            // 6. Add a new entry to the dictionary
            fruitDictionary.Add(4, "Grapes");

            // Print all key-value pairs
            Console.WriteLine("Fruit Dictionary entries:");
            foreach (KeyValuePair<int, string> kvp in fruitDictionary)
            {
                Console.WriteLine($"ID: {kvp.Key}, Fruit Name: {kvp.Value}");
            }
        }
    }
}