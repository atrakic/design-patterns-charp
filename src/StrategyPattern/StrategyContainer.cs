namespace StrategyPattern;

public class StrategyContainer
{
    private IStrategy? _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        if (_strategy != null)
        {
            _strategy.Execute();
        }
    }
}
