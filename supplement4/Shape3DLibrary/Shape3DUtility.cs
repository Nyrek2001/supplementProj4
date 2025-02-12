using System;

namespace Shape3DLibrary
{
    public static class Shape3DUtility
    {
        public static string DescribeShape(Shape3D shape)
        {
            return $"Surface Area: {shape.GetSurfaceArea()}, Volume: {shape.GetVolume()}";
        }

        public static double CalculateDiagonal(RectangularPrism prism)
        {
            return Math.Sqrt(Math.Pow(prism.Length, 2) + Math.Pow(prism.Width, 2) + Math.Pow(prism.Height, 2));
        }

        public static Cube CreateCubeFromLength(double length)
        {
            return new Cube(length);
        }
    }
}
