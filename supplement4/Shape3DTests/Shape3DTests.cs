using Xunit;
using Shape3DLibrary;

public class Shape3DTest
{
    [Fact]
    public void Shape3D_ShouldBeAbstract()
    {
        Assert.True(typeof(Shape3D).IsAbstract);
    }
}
