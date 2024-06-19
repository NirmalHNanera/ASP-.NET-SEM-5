using System;

namespace Lab_1
{
    class Furniture
    {
        public string Material { get; set; }
        public double Price { get; set; }
    }

    class Table : Furniture
    {
        public double Height { get; set; }
        public double Surface_Area { get; set; }
    }
}