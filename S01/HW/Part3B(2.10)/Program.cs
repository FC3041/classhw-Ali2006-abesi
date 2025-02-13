namespace math4;

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
    public static double com_e_to_x_2(double x , double pre){
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
     public static double abs_value(double n){
        if (n<0){
            return -1*n;
        }
        return n;
    }
    public static bool is_close(double x , double y ){
        double distance = 0.001;
        double real_distance = abs_value(x-y);
        // Console.WriteLine("The distance between these nums : "+real_distance);
        if (real_distance<=distance){
            return true ;
        }
        return false;
    }

    static void Main(string[] args)
    {
        double x = comoute_e_to_x(1, 0.000001);
        double y = com_e_to_x_2(1, 0.000001);
        bool flag = is_close(x,y);
        Console.WriteLine(flag);

    }
}
