using System;

namespace Lab_1
{
    class Distance
    {
        private double dist1;
        private double dist2;
        private double dist3;

        public Distance(double d1, double d2)
        {
            dist1 = d1;
            dist2 = d2;
            dist3 = dist1 + dist2;
        }

        public void DisplayTotalDistance()
        {
            Console.WriteLine($"Total Distance: {dist3}");
        }
    }
}