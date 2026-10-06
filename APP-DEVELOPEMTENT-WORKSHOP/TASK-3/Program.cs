using System;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declare and initialize variables of different data types
            byte myByte = 255;
            short myShort = 32000;
            int myInt = 100;
            long myLong = 9000000000L;
            float myFloat = 5.75f;
            double myDouble = 19.99;
            decimal myDecimal = 99.99m;
            char myChar = 'A';
            bool myBool = true;

            // 2. Convert the integer value 42 to a string and store it in a new variable
            int intValue = 42;
            string strFromInt = intValue.ToString();

            // 3. Convert a string "3.14" to a double and store it in a new variable
            string strValue = "3.14";
            double doubleFromString = Convert.ToDouble(strValue); // Or double.Parse(strValue)

            // 4. Print all variables to the console with appropriate labels showing their types and values
            Console.WriteLine("--- Declared Data Types ---");
            Console.WriteLine($"byte    | Type: {myByte.GetType().Name,-8} | Value: {myByte}");
            Console.WriteLine($"short   | Type: {myShort.GetType().Name,-8} | Value: {myShort}");
            Console.WriteLine($"int     | Type: {myInt.GetType().Name,-8} | Value: {myInt}");
            Console.WriteLine($"long    | Type: {myLong.GetType().Name,-8} | Value: {myLong}");
            Console.WriteLine($"float   | Type: {myFloat.GetType().Name,-8} | Value: {myFloat}");
            Console.WriteLine($"double  | Type: {myDouble.GetType().Name,-8} | Value: {myDouble}");
            Console.WriteLine($"decimal | Type: {myDecimal.GetType().Name,-8} | Value: {myDecimal}");
            Console.WriteLine($"char    | Type: {myChar.GetType().Name,-8} | Value: {myChar}");
            Console.WriteLine($"bool    | Type: {myBool.GetType().Name,-8} | Value: {myBool}");

            Console.WriteLine("\n--- Type Conversions ---");
            Console.WriteLine($"Integer 42 converted to string  | Type: {strFromInt.GetType().Name,-8} | Value: \"{strFromInt}\"");
            Console.WriteLine($"String \"3.14\" converted to double | Type: {doubleFromString.GetType().Name,-8} | Value: {doubleFromString}");
        }
    }
}