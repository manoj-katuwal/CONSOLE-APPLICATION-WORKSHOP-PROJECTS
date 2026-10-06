using System;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            double radius = 5.0;

            // १. PI को भ्यालु परिवर्तन गर्न खोज्दा (Attempting to modify PI):
            // Un-comment to see error:
            // Circle.PI = 3.14159; 

            // २. Area र Perimeter Calculate गरेर प्रिन्ट गर्ने:
            double area = myCircle.CalculateArea(radius);
            double perimeter = myCircle.CalculatePerimeter(radius);

            Console.WriteLine($"Circle Radius: {radius}");
            Console.WriteLine($"Area of Circle: {area}");
            Console.WriteLine($"Perimeter of Circle: {perimeter}");
        }
    }
}