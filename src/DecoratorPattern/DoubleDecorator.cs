namespace DecoratorPattern;

public class DoubleDecorator : Rectangle
{
    private Brush? _doubleShade = null;
    private Rectangle? _innerRectangle = null;

    public DoubleDecorator() : base(0, 0)
    {
    }

    public void SetDoubleShade(Brush doubleShade)
    {
        _doubleShade = doubleShade;
    }

    public void SetInnerRectangle(Rectangle innerRectangle)
    {
        _innerRectangle = innerRectangle;
    }

    public new void Draw()
    {
        base.Draw();
        _doubleShade?.Draw(this);
        _innerRectangle?.Draw(); // Draw the inner rectangle
    }
}
