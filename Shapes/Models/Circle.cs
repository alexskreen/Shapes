using System;

namespace Shapes.Models
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(((Radius * Radius) * 3.14), 2);
        }
    }
}