namespace ObserverPattern;
public class Drawer : IObserver
{
    private Shape? _shape;

    public void SetShape(Shape shape)
    {
        _shape = shape;
    }

    public void Update(Shape shape)
    {
        if (_shape != shape)
        {
            Console.WriteLine($"Drawing {shape.GetType()}");
            _shape = shape;
        }
    }

    public Shape? GetShape()
    {
        return _shape;
    }
}
