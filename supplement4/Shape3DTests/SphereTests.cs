using Xunit;
using Shape3DLibrary;
using System;

public class SphereTests
{
    [Fact]
    public void Sphere_SurfaceArea_ShouldBeCorrect()
    {
        double radius = 5;
        Sphere sphere = new Sphere(radius);
        double expectedSurfaceArea = 4 * Math.PI * Math.Pow(radius, 2);

        double actualSurfaceArea = sphere.GetSurfaceArea();

        Assert.Equal(expectedSurfaceArea, actualSurfaceArea, precision: 5);
    }

    [Fact]
    public void Sphere_Volume_ShouldBeCorrect()
    {
        double radius = 5;
        Sphere sphere = new Sphere(radius);
        double expectedVolume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);

        double actualVolume = sphere.GetVolume();

        Assert.Equal(expectedVolume, actualVolume, precision: 5);
    }
}
