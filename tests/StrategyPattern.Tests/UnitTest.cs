namespace StrategyPattern.Tests;

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
}
