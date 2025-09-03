public class ResourceManager : IDisposable
{
    public ResourceManager() { }

    public bool IsDisposed = false;
    public void Dispose()
    {
        if (!IsDisposed)
        {
            System.Console.WriteLine("");
        }
        IsDisposed = true;
    }

   
}