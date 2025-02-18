namespace LeapYear;

class Program
{   public static void is_leap_year(int year){
    if ((year%400==0)||((year%4==0)&&(year%100!=0))){
        Console.WriteLine("True");
    }
    else{
        Console.WriteLine("False");
    }
}
    static void Main(string[] args)
    {
        int[] years = {	1792,1796,1800,1804,1900,1904,2000,2004};
        int len = years.Length;
        for(int i=0;i<len;i++){
            is_leap_year(years[i]);
        }
    }
}
