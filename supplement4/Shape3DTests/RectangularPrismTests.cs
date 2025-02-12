using Xunit;
using Shape3DLibrary;

public class RectangularPrismTests
{
    [Fact]
    public void RectangularPrism_SurfaceArea_ShouldBeCorrect()
    {
        double length = 4, width = 3, height = 2;
        RectangularPrism prism = new RectangularPrism(length, width, height);
        double expectedSurfaceArea = 2 * ((length * width) + (width * height) + (height * length));

        double actualSurfaceArea = prism.GetSurfaceArea();

        Assert.Equal(expectedSurfaceArea, actualSurfaceArea);
    }

    [Fact]
    public void RectangularPrism_Volume_ShouldBeCorrect()
    {
        double length = 4, width = 3, height = 2;
        RectangularPrism prism = new RectangularPrism(length, width, height);
        double expectedVolume = length * width * height;

        double actualVolume = prism.GetVolume();

        Assert.Equal(expectedVolume, actualVolume);
    }
}
