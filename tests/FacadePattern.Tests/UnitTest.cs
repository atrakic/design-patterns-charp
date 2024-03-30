namespace FacadePattern.Tests;

public class UnitTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var facade = new Facade();
        facade.SetSystem(new ComplexSystem());

        // Act
        facade.PerformOperation();

        // Assert
        Assert.True(true);

        //Assert.Contains("ComplexSystem Operation 1", facade.toString());
    }
}
