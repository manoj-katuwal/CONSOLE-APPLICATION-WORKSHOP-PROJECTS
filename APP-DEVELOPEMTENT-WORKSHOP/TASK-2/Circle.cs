using System;

namespace DataTypeDemo
{
    public class Circle
    {
        // constant variable PI घोषणा र initialize गरिएको
        public const double PI = 3.14;

        // Area (क्षेत्रफल) निकाल्ने Method
        public double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }

        // Perimeter/Circumference (परिधि) निकाल्ने Method
        public double CalculatePerimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}