namespace Calendar;

class Program
{   public static string print_month(int num){
    string [] months=new string[12];
    months[0]="Jan";
    months[1]="Feb";
    months[2]="Mar";
    months[3]="Apr";
    months[4]="May";
    months[5]="Jun";
    months[6]="Jul";
    months[7]="Aug";
    months[8]="Sep";
    months[9]="Oct";
    months[10]="Nov";
    months[11]="Dec";
    return months[num-1];
}
    static void Main(string[] args)
    {
        string month = print_month(12);
        Console.WriteLine(month);
    }
}
