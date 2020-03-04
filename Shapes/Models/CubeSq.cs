namespace Shapes.Models
{
    public class CubeSq
    {
        public Square Face { get; set; }

        public CubeSq(Square side)
        {
            Face = side;
        }
        public int GetVolume()
        {
            int length = Face.Length;
            return length * length * length;
        }
        public int GetSurfaceArea()
        {
            int length = Face.Length;
            return (length * length) * 6;
        }
    }
}