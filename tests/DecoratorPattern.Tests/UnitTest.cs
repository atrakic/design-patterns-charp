namespace DecoratorPattern.Tests;

using DecoratorPattern;
using Xunit;

public class UnitTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        DoubleDecorator doubleDecorator = new();
        ShadedDecorator shadedDecorator = new();

        // Act
        shadedDecorator.SetShade(new Brush());
        shadedDecorator.Draw(); // Draw the decorated rectangle

        // Assert
        Assert.IsAssignableFrom<Rectangle>(shadedDecorator);
        Assert.IsNotType<DoubleDecorator>(shadedDecorator);
        Assert.IsType<ShadedDecorator>(shadedDecorator);
        //Assert.Contains("Drawing rectangle\n", shadedDecorator.ToString());
    }
}
