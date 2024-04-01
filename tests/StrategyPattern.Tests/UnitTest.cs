namespace StrategyPattern.Tests;

using NSubstitute;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        StrategyContainer container = new();
        container.SetStrategy(new ConcreteStrategy());
        container.ExecuteStrategy(); // Output: "ConcreteStrategy executed"

        container.SetStrategy(new AlternateConcreteStrategy());
        container.ExecuteStrategy(); // Output: "AlternateConcreteStrategy executed"

        Assert.True(container is not null);
    }

    [Fact]
    public void TestNSubstitute()
    {
        // Arrange
        var strategy = Substitute.For<IStrategy>();
        var container = new StrategyContainer();

        // Act
        container.SetStrategy(strategy);
        container.ExecuteStrategy();

        // Assert
        strategy.Received().Execute();
    }

}
