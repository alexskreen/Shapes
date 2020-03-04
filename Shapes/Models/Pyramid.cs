using System;

namespace Shapes.Models
{
    public class Pyramid
    {
        public Triangle Face { get; set;}
        public double Width; 

        public Pyramid(Triangle side, double width)
        {
            Face = side;
            Width = width;
        }
        public double GetVolume()
        {
            double height = Face.TriHeight;
            double bases = Face.TriBase;
            double width = Width;
            return Math.Round(((width * height * bases)/3),2);
        }



    }
}