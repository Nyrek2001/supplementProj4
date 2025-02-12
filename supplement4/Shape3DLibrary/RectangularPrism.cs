namespace Shape3DLibrary
{
    public class RectangularPrism : Shape3D
    {
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }

        public RectangularPrism(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override double GetSurfaceArea()
        {
            return 2 * ((Length * Width) + (Width * Height) + (Height * Length));
        }

        public override double GetVolume()
        {
            return Length * Width * Height;
        }
    }
}
