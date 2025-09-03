public class LambdaProblems
{
    public LambdaProblems() { }


    public static Func<string, int> GetStringLengthCalculator = (a) => { return a.Length; };

}
    