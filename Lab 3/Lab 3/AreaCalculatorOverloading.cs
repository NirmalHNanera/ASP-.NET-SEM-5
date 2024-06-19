using System;

namespace Lab3
{
    class AreaCalculatorOverloading
    {
        public static double CalculateArea(int side)
        {
            return side * side; // Area of square
        }

        public static double CalculateArea(double length, double width)
        {
            return length * width; // Area of rectangle
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius; // Area of circle
        }
    }
}