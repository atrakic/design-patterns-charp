namespace SingletonPattern;
public class Singleton
{
    private static Singleton _instance;

    // Private constructor to prevent direct creation
    private Singleton() { }

    // Get the single instance of the class
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
