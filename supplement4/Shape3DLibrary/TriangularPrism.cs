using System;

namespace Shape3DLibrary
{
    public class TriangularPrism : Shape3D
    {
        public double Base { get; }
        public double Height { get; }
        public double Length { get; }

        public TriangularPrism(double baseLength, double height, double length)
        {
            Base = baseLength;
            Height = height;
            Length = length;
        }

        public override double GetSurfaceArea()
        {
            double baseArea = 0.5 * Base * Height;
            return (2 * baseArea) + (Length * (Base + Height));
        }

        public override double GetVolume()
        {
            return 0.5 * Base * Height * Length;
        }
    }
}
