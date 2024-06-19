using System;

namespace Lab3
{
    class AreaCalculator
    {
        public static double CalculateArea(double side)
        {
            return side * side; // Area of square
        }

        public static double CalculateArea(double length, double width)
        {
            return length * width; // Area of rectangle
        }
    }
}