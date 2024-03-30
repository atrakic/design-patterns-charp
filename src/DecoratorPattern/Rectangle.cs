namespace DecoratorPattern;

// define the component that will be decorated
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }
}

public class Brush
{
    public void Draw(Rectangle rectangle)
    {
        Console.WriteLine("Drawing shade on rectangle");
    }
}
