public class SafeCounter
{
    public int Count = 0;
    
    public void Increment()
    {
        Interlocked.Increment(ref Count);
    }
    
}