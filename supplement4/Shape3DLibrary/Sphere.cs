using System;

namespace Shape3DLibrary
{
    public class Sphere : Shape3D
    {
        public double Radius { get; }

        public Sphere(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero.");
            Radius = radius;
        }

        public override double GetSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetVolume()
        {
            return (4.0 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
