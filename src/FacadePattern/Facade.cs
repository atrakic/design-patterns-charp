namespace FacadePattern;

public class Facade : IFacade
{
    private readonly ComplexSystem _complexSystem;

    public Facade(ComplexSystem complexSystem)
    {
        _complexSystem = complexSystem;
    }

    public void PerformOperation()
    {
        _complexSystem.Operation1();
        _complexSystem.Operation2();
        _complexSystem.Operation3();
    }

}
