namespace math3;

class Program
{   
    public static double abs_value(double n){
        if (n<0){
            return -1*n;
        }
        return n;
    }
    public static bool is_close(double x , double y ){
        double distance = 0.001;
        if (abs_value(x-y)<=distance){
            return true ;
        }
        return false;
    }
    static void Main(string[] args)
    {
        bool x = is_close(10,10.02222);
        Console.WriteLine(x);
    }
}
