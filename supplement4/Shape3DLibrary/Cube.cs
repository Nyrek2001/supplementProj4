namespace Shape3DLibrary
{
    public class Cube : RectangularPrism
    {
        public double Side { get; }

        public Cube(double side) : base(side, side, side)
        {
            Side = side;
        }
    }
}
