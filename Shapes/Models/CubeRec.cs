namespace Shapes.Models
{
    public class CubeRec
    {
        public Rectangle Face { get; set; }

        public CubeRec(Rectangle side)
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