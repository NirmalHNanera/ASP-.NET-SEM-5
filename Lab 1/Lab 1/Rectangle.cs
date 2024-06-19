using System;

namespace Lab_1
{
    class Rectangle
    {
        private double length;
        private double width;
        private double area;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
            area = length * width;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }
}