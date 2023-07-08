class FileSystem
{
    private FileSystem(){} // closing off instantiation, by making the constructor private

    private static FileSystem _instance;
    public static FileSystem Instance 
    {
        get
        {
            if (_instance == null)
            {
                _instance = new FileSystem();
            }
            return _instance;
        }
    }

    public Object File;
}

class MyClass
{
    void MyMethod()
    {
        var f = FileSystem.Instance.File;

    }
}