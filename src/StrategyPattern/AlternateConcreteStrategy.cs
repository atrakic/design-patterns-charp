namespace StrategyPattern;

public class AlternateConcreteStrategy : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("AlternateConcreteStrategy executed");
    }
}
