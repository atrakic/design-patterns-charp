namespace DecoratorPattern;

// define the implementation of the decorator

public class ShadedDecorator : Rectangle
{
    private Brush? _shade;

    public ShadedDecorator() : base(0, 0)
    {
    }

    public void SetShade(Brush shade)
    {
        _shade = shade;
    }

    public new void Draw()
    {
        base.Draw();
        _shade?.Draw(this);
    }
}
