using System.Net.Http.Headers;

namespace math7;

class Program
{   
    public static double pow(double a , int b){
        double result = 1;
        for(int i=0;i<b;i++){
            result*=a;
        }
        return result;
    }
    public static double com_root_n(double x ,int n, double pre){
    double low=0.0;
    double up=x;
    int count = 0;
    while((up-low)>pre){
        double mid = (up+low)/2;
        if(pow(mid,n)<x){
            low = mid ;
        }
        else{
            up=mid;
        }
        count++;
    }
    Console.WriteLine("the iteration : "+count);
    return (up+low)/2;
}
    static void Main(string[] args)
    {
        Console.WriteLine(com_root_n(27,3,0.000001));
    }
}
