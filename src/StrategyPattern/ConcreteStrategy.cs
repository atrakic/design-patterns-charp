namespace StrategyPattern;

public class ConcreteStrategy : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("ConcreteStrategy executed");
    }
}
