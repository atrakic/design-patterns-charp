namespace SingletonPattern.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        // Arrange
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        // Act
        var result = instance1 == instance2;

        // Assert
        Assert.True(result);
    }
}
