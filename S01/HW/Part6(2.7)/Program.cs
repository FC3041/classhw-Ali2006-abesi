namespace Date0;

class Program
{   public static int days_in_month(int num){
    int[]each_month_days={31,28,31,30,31,30,31,31,30,31,30,31};
    return each_month_days[num-1];
}
    static void Main(string[] args)
    {
        int days = days_in_month(12);
        Console.WriteLine(days);
    }
}
