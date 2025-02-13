namespace math2;

class Program
{   
    public static double com_e_to_x(double x , double pre){
        double n = 1.0;
        double max_pre = 1.0;
        double sum = 1.0;
        while(max_pre>pre){
            max_pre*=x/n;
            sum+=max_pre;
            n++;
        }
        return sum;
    }
    
    static void Main(string[] args)
    {   
        double e_to_x = com_e_to_x(1,0.0001);
        Console.WriteLine(e_to_x);
    }
}
