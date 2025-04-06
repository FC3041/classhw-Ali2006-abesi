namespace math8;

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
    public static double log_x_in_e(double x , double pre){
        double low = 0.0;
        double up = x;
        while(up-low>pre){
            double mid = (up+low)/2;
            if(com_e_to_x(mid , pre)<x){
                low=mid;
            }
            else{
                up=mid;
            }
        }
        return (up+low)/2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(log_x_in_e(2.718281828459045,1e-10));
    }
}
