namespace math1;

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
    public static int pow(int x , int y){
    int result = 1;
    while(y>0){
        result*=x;
        y--;
    }
    return result;
}
    public static double comoute_e_to_x(int x , double pre){
        int n=0;
        double max_pre=1.0;
        double sum_e_to_x=0;
        while (max_pre>pre){
            sum_e_to_x+=max_pre;
            n++;
            max_pre=pow(x,n)/fac(n);
        }
    return sum_e_to_x;
    }
    static void Main(string[] args)
    {
        double e_to_x=comoute_e_to_x(2,0.000001);
        Console.WriteLine(e_to_x);
    }
}
