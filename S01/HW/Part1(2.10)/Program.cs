namespace math0;

class Program
{   
    public static double fac(int n){
        if (n==0){
            return 1 ;
        }
        else if (n<0){
            Console.WriteLine("None");
        }
        else{
            double result = 1;
            for(int i=1;i<n+1;i++){
                result*=i;
            }
            return result;
        }
        return 0 ;
    }
    public static double compute_e(double pre){
        int n = 0;
        double sum_e = 0.0;
        double max_pre = 1.0;
        while(max_pre>pre){
            sum_e+=max_pre;
            n++;
            max_pre=1.0/fac(n);
        }
        return sum_e;
}
    static void Main(string[] args)
    {   
        double e = compute_e(0.0001);
        Console.WriteLine(e);
    }
}
