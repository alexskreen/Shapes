using System;

namespace Shapes.Models
{
    public class Triangle
    {
        public double TriHeight { get; set; }
        public double TriBase { get; set; }

        public Triangle (double triHeight, double triBase)
        {
            TriHeight = triHeight;
            TriBase = triBase;
        }

        public double GetArea()
        {
            return Math.Round((TriHeight * TriBase)/2);
        }
        
    }
    
}