using System;
namespace Shapes.Models
{
    public class Sphere
    {
        public Circle Face { get; set; }

        public Sphere(Circle radius)
        {
            Face = radius;
        }

        public double GetVolume()
        {
            double radius = Face.Radius;
            return Math.Round((4 * Math.PI * Math.Pow(radius, 3) /3), 2);
        }
    }
}