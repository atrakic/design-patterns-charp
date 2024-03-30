namespace FacadePattern;

public class Facade : IFacade
{
    private ComplexSystem _system;

    public void SetSystem(ComplexSystem complexSystem)
    {
        _system = complexSystem;
    }

    public void PerformOperation()
    {
        _system.Operation1();
        _system.Operation2();
        _system.Operation3();
    }
}
