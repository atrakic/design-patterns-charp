namespace ObserverPattern.Tests;
using Moq;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        // Arrange
        var drawer = new Drawer();
        var shape = new Shape();
        var observer = new Mock<IObserver>();
        observer.Setup(o => o.Update(shape));

        // Act
        //drawer.Subscribe(observer.Object);
        drawer.SetShape(shape);
        //shape.SetDrawn(true);
        //observer.Setup(o => o.Update(shape));
        //drawer.Update(shape);

        // Assert
        observer.Verify(o => o.Update(shape), Times.Never);

        Assert.Equal(shape, drawer.GetShape());
    }
}
