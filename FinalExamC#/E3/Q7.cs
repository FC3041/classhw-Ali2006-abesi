public class DelegateProblems
{

    public DelegateProblems() { }
    public static string ToUpper(string a)
    {
        return a.ToUpper();
    }

    public  static string ToLower(string a)
    {
        return a.ToLower();
    }

    public static string ProcessString(string a, Func<string,string> f)
    {
        return f(a);
    }
}