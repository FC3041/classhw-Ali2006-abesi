namespace math5;

class Program
{   
    public static double abs_value(double x){
        if(x<0){
            return -1*x; 
        }
        return x;
    }
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
    public static double pow(double x , int y){
    double result = 1;
    while(y>0){
        result*=x;
        y--;
    }
    return result;
    }

public static double com_sin(double x , double pre){
    int n = 0 ;
    x = x*(Math.PI/180.0);
    double max_pre = x;
    double sum_sin = 0 ;
    while (abs_value(max_pre)>pre){
        sum_sin+=max_pre;
        n++;
        max_pre=pow(-1,n)*pow(x,2*n+1);
        max_pre=max_pre/fac(2*n+1);
        Console.WriteLine(max_pre);
    }
    return Math.Round(sum_sin,1);
}
    static void Main(string[] args)
    {
        Console.WriteLine(com_sin(45, 0.001));
        Console.WriteLine(com_sin(90, 0.001));
        Console.WriteLine(com_sin(0, 0.001));
    }
}
