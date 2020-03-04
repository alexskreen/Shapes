namespace Shapes.Models
{
    public class Square
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Square(int sideLength, int sideWidth)
        {
            Length = sideLength;
            Width = sideWidth;
        }

        public int GetArea()
        {
            return Length * Width;
        }

        public bool IsSquare()
        {
            if (Length == Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}