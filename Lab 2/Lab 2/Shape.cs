using System;

namespace Lab2
{
    interface IShape
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double side);
    }

    class Shape : IShape
    {
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double Square(double side)
        {
            return side * side;
        }
    }
}